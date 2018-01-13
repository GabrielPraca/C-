using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace Cimg
{
    public partial class FrmMain : Form
    {
        [DllImport("Kernel32.dll")]
        private static extern uint GetTickCount();
        [DllImport("User32.dll")]
        private static extern int GetKeyState(Keys VirtualKey);
        Bitmap BitNull = new Bitmap(1, 1);

        RecursoImg[] Imagens = new RecursoImg[0];
        List<ElementoImg> Elementos = new List<ElementoImg>();
        ElementoImg EdtElemento = null;
        List<int> EdtPontos = new List<int>();
        TipoElem SelecTipo;
        bool MouseVisivel = false;
        string MouseTipo = "CurSeta";
        Point MousePos = new Point(),
              VistaOffset = new Point();
        Rectangle Dimensao = new Rectangle();
        float Zoom = 1;
        string edtCaminho;

        #region Funções do Form
        public FrmMain()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(FrmMain_MouseWheel);
        }

        void FrmMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (GetKeyState(Keys.LControlKey) < 0)
            {
                Zoom += (float)e.Delta * 0.001f;
                if (Zoom < 0.01f)
                    Zoom = 0.01f;
                else if (Zoom > 10f)
                    Zoom = 10f;
            }
        }

        void FrmMain_Shown(object sender, EventArgs e)
        {
            Thread Th = new Thread(new ThreadStart(Render));
            Th.IsBackground = true;
            Th.Priority = ThreadPriority.BelowNormal;
            Th.Start();
        }

        void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                KeyDown_Esc();
            else if (e.KeyCode == Keys.D0)
            {
                if (GetKeyState(Keys.LControlKey) < 0)
                    Zoom = 1;
            }
        }

        void KeyDown_Esc()
        {
            if (EdtElemento != null)
            {
                if (EdtElemento.Pontos.Count < 2)
                    lock (Elementos) { Elementos.Remove(EdtElemento); }
                EdtElemento = null;
                EdtPontos.Clear();
            }
            else
            {
                SelecTipo = 0;
                MouseTipo = "CurSeta";
            }
        }
        #endregion

        #region Funções dos Demais Controles do Form (Botões, etc...)

        void BtnRet_Click(object sender, EventArgs e)
        {
            KeyDown_Esc();
            SelecTipo = TipoElem.RETANGULO;
            MouseTipo = "CurCruzado";
        }

        void BtnCirc_Click(object sender, EventArgs e)
        {
            KeyDown_Esc();
            SelecTipo = TipoElem.CIRCULO;
            MouseTipo = "CurCruzado";
        }

        void BtnPolig_Click(object sender, EventArgs e)
        {
            KeyDown_Esc();
            SelecTipo = TipoElem.POLIGONO;
            MouseTipo = "CurCruzado";
        }

        void CbFill_CheckedChanged(object sender, EventArgs e)
        {
            if (EdtElemento != null)
            {
                lock (EdtElemento)
                    EdtElemento.Tipo ^= TipoElem.PREENCHIDO;
            }
        }

        void TxtTamanho_TextChanged(object sender, EventArgs e)
        {
            string Final = "";
            for (int i = 0; i < TxtTamanho.Text.Length; i++)
            {
                if (TxtTamanho.Text[i] >= '0' && TxtTamanho.Text[i] <= '9')
                    Final += TxtTamanho.Text[i];
            }
            TxtTamanho.Text = Final;
        }

        void TxtTamanho_Leave(object sender, EventArgs e)
        {
            if (TxtTamanho.Text == "")
                TxtTamanho.Text = "1";
        }
        #endregion

        #region Funções Diversas
        void CarregarRecImg(string Nome, string Caminho, ref RecursoImg[] Buffer)
        {
            try
            {
                if (!string.IsNullOrEmpty(Caminho) || Caminho.ToLower() != "(null)")
                {
                    RecursoImg tmpRImg = new RecursoImg(Nome, Caminho);
                    Array.Resize(ref Buffer, Buffer.Length + 1);
                    lock (Buffer)
                        Buffer[Buffer.Length - 1] = tmpRImg;
                }
            }
            catch { }
        }

        void CarregarImagens(object Dados)
        {
            List<string[]> Lista = (List<string[]>)Dados;
            foreach (string[] item in Lista)
            {
                try { CarregarRecImg(item[0], item[1], ref Imagens); }
                catch { }
            }
        }

        Bitmap LerRecImg(string Nome, ref RecursoImg[] Buffer)
        {
            lock (Buffer)
                try
                {
                    foreach (RecursoImg Rec in Buffer)
                    {
                        lock (Rec)
                            if (Rec.Nome == Nome)
                                return Rec.Img;
                    }
                }
                catch { }

            return BitNull;
        }

        void DrawStringSombra(string Texto, Font Fonte, Color Cor, float x, float y, Graphics G)
        {
            Brush cor = new SolidBrush(Cor);
            G.DrawString(Texto, Fonte, Brushes.Black, x + 1, y + 1);
            G.DrawString(Texto, Fonte, cor, x, y);
            cor.Dispose();
        }
        #endregion

        #region Funções dos Paineis
        void PnlTela_MouseMove(object sender, MouseEventArgs e)
        {
            Point Delta = new Point(e.X - MousePos.X, e.Y - MousePos.Y);

            if (GetKeyState(Keys.RButton) > 1 && GetKeyState(Keys.LControlKey) < 0)
                VistaOffset.Offset(Delta.X, Delta.Y);
            else if (GetKeyState(Keys.RButton) > 1 && EdtPontos.Count > 0)
            {
                Point MouseAntes = TransformarPontoMouse(Zoom, VistaOffset, MousePos);
                Point MouseDepois = TransformarPontoMouse(Zoom, VistaOffset, e.Location);
                lock (EdtElemento)
                    foreach (int indice in EdtPontos)
                    {
                        Point Ponto = EdtElemento.Pontos[indice];
                        Ponto.Offset(MouseDepois.X - MouseAntes.X, MouseDepois.Y - MouseAntes.Y);
                        EdtElemento.Pontos[indice] = Ponto;
                    }
            }
            MousePos = e.Location;
        }

        private void PnlTela_MouseDown(object sender, MouseEventArgs e)
        {
            TxtTamanho_Leave(null, null);
            Point Local = TransformarPontoMouse(Zoom, VistaOffset, MousePos);

            if (e.Button == MouseButtons.Left)
            {
                if (EdtElemento == null)
                {
                    if (SelecTipo != 0)
                    {
                        TipoElem tipo = SelecTipo;
                        if (CbFill.Checked)
                            tipo ^= TipoElem.PREENCHIDO;
                        EdtElemento = new ElementoImg(tipo, Local, int.Parse(TxtTamanho.Text));
                        EdtElemento.Cor = PnlCor.BackColor;
                        lock (Elementos) { Elementos.Add(EdtElemento); }
                    }
                }
                else
                {
                    if (SelecTipo != 0)
                    {
                        lock (EdtElemento)
                            switch ((EdtElemento.Tipo | TipoElem.PREENCHIDO) ^ TipoElem.PREENCHIDO)
                            {
                                case TipoElem.POLIGONO:
                                    EdtElemento.Pontos.Add(Local);
                                    break;
                                case TipoElem.RETANGULO:
                                case TipoElem.CIRCULO:
                                    EdtElemento.Pontos.Add(Local);
                                    KeyDown_Esc();
                                    break;
                            }
                        CalcularDimensao();
                    }
                }
                if (Elementos.Count > 0 && SelecTipo == 0)
                {
                    int[] indices = getIndicePontoMaisPerto(Local);

                    if (getDistancia2D(Elementos[indices[0]].Pontos[indices[1]], Local) <= 5)
                    {
                        if (EdtElemento == null || EdtElemento == Elementos[indices[0]])
                        {
                            EdtElemento = Elementos[indices[0]];
                            if (!EdtPontos.Contains(indices[1]))
                                EdtPontos.Add(indices[1]);

                            TxtTamanho.Text = EdtElemento.Tamanho.ToString();
                            PnlCor.BackColor = EdtElemento.Cor;
                        }
                    }
                }
            }
        }

        void PnlTela_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
            MouseVisivel = true;
        }

        void PnlTela_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
            MouseVisivel = false;
        }

        void PnlCor_Click(object sender, EventArgs e)
        {
            CDSelec.Color = PnlCor.BackColor;
            if (CDSelec.ShowDialog() == DialogResult.OK)
            {
                PnlCor.BackColor = CDSelec.Color;
                if (EdtElemento != null)
                    lock (EdtElemento) { EdtElemento.Cor = CDSelec.Color; }
            }
        }
        #endregion

        #region Funções dos Pontos do Objeto
        void CalcularDimensao()
        {
            lock (Elementos)
            {
                int xMaior = Elementos[0].Pontos[0].X;
                int xMenor = Elementos[0].Pontos[0].X;
                int yMaior = Elementos[0].Pontos[0].Y;
                int yMenor = Elementos[0].Pontos[0].Y;
                foreach (ElementoImg elem in Elementos)
                {
                    lock (elem)
                    {
                        foreach (Point P in elem.Pontos)
                        {
                            if (P.X > xMaior)
                                xMaior = P.X;
                            else if (P.X < xMenor)
                                xMenor = P.X;

                            if (P.Y > yMaior)
                                yMaior = P.Y;
                            else if (P.Y < yMenor)
                                yMenor = P.Y;
                        }
                    }
                }

                Dimensao = new Rectangle(xMenor, yMenor, xMaior - xMenor, yMaior - yMenor);
            }
        }

        int[] getIndicePontoMaisPerto(Point Local)
        {
            lock (Elementos)
            {
                int[] indices = { -1, -1 };
                double menorDist = -1;

                for (int ie = 0; ie < Elementos.Count; ie++)
                {
                    lock (Elementos[ie])
                    {
                        for (int ip = 0; ip < Elementos[ie].Pontos.Count; ip++)
                        {
                            double dist = getDistancia2D(Local, Elementos[ie].Pontos[ip]);
                            if (dist <= menorDist || menorDist < 0)
                            {
                                indices[0] = ie;
                                indices[1] = ip;
                                menorDist = dist;
                            }
                        }
                    }
                }
                return indices;
            }
        }

        Point getPontoMaisPerto(Point Local)
        {
            lock (Elementos)
            {
                Point PMaisPerto = Point.Empty;
                double menorDist = -1;

                foreach (ElementoImg elem in Elementos)
                {
                    lock (elem)
                    {
                        foreach (Point P in elem.Pontos)
                        {
                            double dist = getDistancia2D(Local, P);
                            if (dist < menorDist || menorDist < 0)
                            {
                                PMaisPerto = P;
                                menorDist = dist;
                            }
                        }
                    }
                }
                return PMaisPerto;
            }
        }

        double getDistancia2D(Point P1, Point P2)
        {
            return Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        }

        Point TransformarPontoMouse(float Zoom, Point Offset, Point MousePos)
        {
            int Width = PnlTela.Width,
                Height = PnlTela.Height;

            //Aplica o Offset
            MousePos.X -= Offset.X;
            MousePos.Y -= Offset.Y;
            //Aplica o Zoom
            MousePos.X = (int)(MousePos.X / Zoom - (Width / Zoom - Width) / 2 + 0.5f);
            MousePos.Y = (int)(MousePos.Y / Zoom - (Height / Zoom - Height) / 2 + 0.5f);

            return MousePos;
        }

        void TransformarPontos(float Zoom, Point Offset, ref Point[] Pontos)
        {
            int Width = PnlTela.Width,
                Height = PnlTela.Height;

            if (Zoom != 1 || Offset.X != 0 || Offset.Y != 0)
            {
                for (int i = 0; i < Pontos.Length; i++)
                {
                    //Aplica o Zoom
                    Pontos[i].X = (int)(Pontos[i].X * Zoom + (Width - Width * Zoom) / 2);
                    Pontos[i].Y = (int)(Pontos[i].Y * Zoom + (Height - Height * Zoom) / 2);
                    //Aplica o Offset
                    Pontos[i].X += Offset.X;
                    Pontos[i].Y += Offset.Y;
                }
            }
        }

        void DesenharPontos(ref Point[] Pontos, Graphics G)
        {
            uint angulo = GetTickCount() / 2 % 360;
            for (int i = 0; i < Pontos.Length; i++)
            {
                G.DrawArc(Pens.Black,
                          Pontos[i].X - 2,
                          Pontos[i].Y - 2,
                          4, 4,
                          angulo, 180f);
                G.DrawArc(Pens.White,
                          Pontos[i].X - 2,
                          Pontos[i].Y - 2,
                          4, 4,
                          angulo + 180, 180f);
            }
        }
        #endregion

        void Render()
        {
            #region Inicialização
            BufferedGraphics Buffer = BufferedGraphicsManager.Current.Allocate(PnlTela.CreateGraphics(), PnlTela.DisplayRectangle);
            Graphics G = Buffer.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            //Carrega os cursores
            {
                List<string[]> Lista = new List<string[]>();
                Lista.Add(new string[] { "CurSeta", Application.StartupPath + @"\Recursos\Cursores\CurSeta.png" });
                Lista.Add(new string[] { "CurCruzado", Application.StartupPath + @"\Recursos\Cursores\CurCruzado.png" });

                Thread Th = new Thread(new ParameterizedThreadStart(CarregarImagens));
                Th.IsBackground = true;
                Th.Start(Lista);
            }

            uint Tick = GetTickCount();
            ushort[] mFPS = new ushort[21];
            Font Fonte1 = new Font("Tahoma", 10);
            Brush bFundo = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.White, Color.LightGray);
            #endregion

            #region Rederização
            while (true)
            {
                #region Calcula FPS
                try
                {
                    mFPS[mFPS[mFPS.Length - 1]] = (ushort)(1000 / (GetTickCount() - Tick));
                    mFPS[mFPS.Length - 1]++;
                    if (mFPS[mFPS.Length - 1] > mFPS.Length - 2)
                        mFPS[mFPS.Length - 1] = 0;
                }
                catch { }
                ushort mediaFPS = 0;
                for (int i = 0; i < mFPS.Length - 2; i++)
                    mediaFPS += mFPS[i];
                mediaFPS /= (ushort)(mFPS.Length - 1);
                Tick = GetTickCount();
                #endregion

                G.FillRectangle(bFundo, PnlTela.DisplayRectangle);
                DrawStringSombra("FPS: " + mediaFPS, Fonte1, Color.Yellow, 0, 0, G);
                DrawStringSombra(string.Format("Zoom: {0}%", (int)(Zoom * 100)), Fonte1, Color.Yellow, 0, Fonte1.Height, G);
                bool mPontos = CbMPontos.Checked;
                {
                    Point[] Pontos = { new Point(Dimensao.X, Dimensao.Y) };
                    TransformarPontos(Zoom, VistaOffset, ref Pontos);
                    G.DrawRectangle(Pens.Yellow, Pontos[0].X, Pontos[0].Y, Dimensao.Width * Zoom, Dimensao.Height * Zoom);
                }
                lock (Elementos)
                {
                    foreach (ElementoImg elem in Elementos)
                    {
                        lock (elem)
                            if ((elem.Tipo & TipoElem.POLIGONO) == TipoElem.POLIGONO)
                            {
                                Point[] Pontos = elem.Pontos.ToArray();
                                if (EdtElemento == elem && SelecTipo != 0)
                                {
                                    Array.Resize(ref Pontos, Pontos.Length + 1);
                                    Point Local = TransformarPontoMouse(Zoom, VistaOffset, MousePos);
                                    Pontos[Pontos.Length - 1] = Local;
                                }
                                TransformarPontos(Zoom, VistaOffset, ref Pontos);
                                if (Pontos.Length > 2 && (elem.Tipo & TipoElem.PREENCHIDO) == TipoElem.PREENCHIDO)
                                    G.FillPolygon(elem.bCor, Pontos);
                                else
                                {
                                    elem.pWidth = elem.Tamanho * Zoom;
                                    G.DrawLines(elem.pCor, Pontos);
                                }
                                if (mPontos)
                                    DesenharPontos(ref Pontos, G);
                            }
                            else if ((elem.Tipo & TipoElem.CIRCULO) == TipoElem.CIRCULO)
                            {
                                Point[] Pontos = elem.Pontos.ToArray();
                                if (EdtElemento == elem && SelecTipo != 0)
                                {
                                    Array.Resize(ref Pontos, Pontos.Length + 1);
                                    Point Local = TransformarPontoMouse(Zoom, VistaOffset, MousePos);
                                    Pontos[Pontos.Length - 1] = Local;
                                }
                                TransformarPontos(Zoom, VistaOffset, ref Pontos);
                                if ((elem.Tipo & TipoElem.PREENCHIDO) == TipoElem.PREENCHIDO)
                                    G.FillEllipse(elem.bCor, Pontos[0].X, Pontos[0].Y, Pontos[1].X - Pontos[0].X, Pontos[1].Y - Pontos[0].Y);
                                else
                                {
                                    elem.pWidth = elem.Tamanho * Zoom;
                                    G.DrawEllipse(elem.pCor, Pontos[0].X, Pontos[0].Y, Pontos[1].X - Pontos[0].X, Pontos[1].Y - Pontos[0].Y);
                                }
                                if (mPontos)
                                    DesenharPontos(ref Pontos, G);
                            }
                            else if ((elem.Tipo & TipoElem.RETANGULO) == TipoElem.RETANGULO)
                            {
                                Point[] Pontos = elem.Pontos.ToArray();
                                if (EdtElemento == elem && SelecTipo != 0)
                                {
                                    Array.Resize(ref Pontos, Pontos.Length + 1);
                                    Point Local = TransformarPontoMouse(Zoom, VistaOffset, MousePos);
                                    Pontos[Pontos.Length - 1] = Local;
                                }
                                TransformarPontos(Zoom, VistaOffset, ref Pontos);
                                if ((elem.Tipo & TipoElem.PREENCHIDO) == TipoElem.PREENCHIDO)
                                    G.FillRectangle(elem.bCor, Pontos[0].X, Pontos[0].Y, Pontos[1].X - Pontos[0].X, Pontos[1].Y - Pontos[0].Y);
                                else
                                {
                                    elem.pWidth = elem.Tamanho * Zoom;
                                    G.DrawRectangle(elem.pCor, Pontos[0].X, Pontos[0].Y, Pontos[1].X - Pontos[0].X, Pontos[1].Y - Pontos[0].Y);
                                }
                                if (mPontos)
                                    DesenharPontos(ref Pontos, G);
                            }
                    }
                }

                if (MouseVisivel)
                {
                    Point Local = TransformarPontoMouse(Zoom, VistaOffset, MousePos);
                    string tmpStr = string.Format("({0}, {1}", Local.X, Local.Y);

                    if (Elementos.Count > 0 && MouseTipo == "CurSeta")
                    {
                        Point[] Pontos = { getPontoMaisPerto(Local) };
                        tmpStr += string.Format(", {0:0}", getDistancia2D(Pontos[0], Local));
                        TransformarPontos(Zoom, VistaOffset, ref Pontos);
                        G.DrawLine(Pens.Red, MousePos, Pontos[0]);
                    }
                    tmpStr += ')';
                    DrawStringSombra(tmpStr, Fonte1, Color.White, MousePos.X, MousePos.Y - G.MeasureString(tmpStr, Fonte1).Height, G);

                    switch (MouseTipo)
                    {
                        case "CurSeta":
                            G.DrawImage(LerRecImg("CurSeta", ref Imagens), MousePos);
                            break;
                        case "CurCruzado":
                            Bitmap tmpImg = LerRecImg("CurCruzado", ref Imagens);
                            G.DrawImage(tmpImg, MousePos.X - tmpImg.Width / 2, MousePos.Y - tmpImg.Height / 2);
                            break;
                    }
                }
                try { Buffer.Render(); }
                catch { }
            #endregion
            }
        }

        #region Programação Salvar/Carregar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edtCaminho))
            {
                SaveFileDialog FD = new SaveFileDialog();
                if (FD.ShowDialog() == DialogResult.OK)
                    edtCaminho = FD.FileName;
            }
            if (!string.IsNullOrEmpty(edtCaminho))
            {
                Thread Th = new Thread(new ParameterizedThreadStart(thSalvarCimg));
                Th.IsBackground = true;
                Th.Start(edtCaminho);
                Text = "Imagem de Coordenada - Salvando...";
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                edtCaminho = FD.FileName;
                Thread Th = new Thread(new ParameterizedThreadStart(thCarregarCimg));
                Th.IsBackground = true;
                Th.Start(FD.FileName);
                Text = "Imagem de Coordenada - Carregando...";
            }
        }

        private void thSalvarCimg(object param)
        {
            string Caminho = (string)param;

            Cimg cimg = new Cimg(Elementos, Dimensao);
            cimg.Salvar(Caminho);
            string[] sCaminho = Caminho.Split('\\');
            Invoke((MethodInvoker)delegate { Text = "Imagem de Coordenada - " + sCaminho[sCaminho.Length - 1]; });
        }

        private void thCarregarCimg(object param)
        {
            string Caminho = (string)param;

            Cimg cimg = Cimg.Carregar(Caminho);
            if (cimg == null)
            {
                Invoke((MethodInvoker)delegate { Text = "Imagem de Coordenada"; });
                MessageBox.Show("Não foi possível carregar o arquivo.");
            }
            else
            {
                Dimensao = cimg.Dimensao;
                lock (Elementos)
                    Elementos = cimg.Elementos;
                string[] sCaminho = Caminho.Split('\\');
                Invoke((MethodInvoker)delegate
                {
                    Text = "Imagem de Coordenada - " + sCaminho[sCaminho.Length - 1];
                    VistaOffset.X = VistaOffset.Y = 0;
                    Zoom = 1;
                });
            }
        }

        private void PnlTela_DragDrop(object sender, DragEventArgs e)
        {
            edtCaminho = ((string[])e.Data.GetData("FileName"))[0];
            Thread Th = new Thread(new ParameterizedThreadStart(thCarregarCimg));
            Th.IsBackground = true;
            Th.Start(edtCaminho);
            Text = "Imagem de Coordenada - Carregando...";
        }

        private void PnlTela_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        #endregion
    }
}
