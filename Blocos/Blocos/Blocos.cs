using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using Blocos.Properties;

using Tao.OpenGl;
using Tao.Platform.Windows;

using Microsoft.DirectX.DirectSound;

namespace Blocos
{
    internal class Blocos : Form
    {
        SimpleOpenGlControl ctrlGl;

        //Variáveis do jogo
        public static EstadosJogo EstadoJogo = EstadosJogo.INTRODUCAO;
        public static SubEstadosJogo SubEstadoJogo = SubEstadosJogo.BAIRRO | SubEstadosJogo.LIVRE;
        public static int refTick; //Tempo de referencia
        public static int ultTick; //Tempo do ultimo frame
        public static Guindaste Guindaste = new Guindaste(false, 0);
        public static List<Andar> Andares = new List<Andar>();
        public static TipoPredio TipoPredioSelec = TipoPredio.Azul;
        public static Predio PredioConstruc;
        public static float AlturaCamera = 0;

        static void Main()
        {
            Application.Run(new Blocos());
            Application.Exit();
        }

        public Blocos()
        {
            InitForm();
            InitOpenGl();

            ctrlGl_Resize(null, null);
        }

        void InitForm()
        {
            //Inicializa o básico do Form
            this.BackColor = Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Name = "Blocos";
            this.Text = "Blocos";
            this.KeyPreview = true;

            //Inicializa o SimpliOpenGlControl
            ctrlGl = new SimpleOpenGlControl();
            ctrlGl.Dock = DockStyle.Fill;
            ctrlGl.InitializeContexts();
            this.Controls.Add(ctrlGl);

            //Inicializa o Timer para repintar a tela
            Timer TimRender = new Timer();
            TimRender.Interval = 10;

            //Inicializa os eventos
            this.FormClosing += new FormClosingEventHandler(Blocos_FormClosing);
            this.KeyDown += new KeyEventHandler(Blocos_KeyDown);
            this.KeyPress += new KeyPressEventHandler(Blocos_KeyPress);
            ctrlGl.Paint += new PaintEventHandler(ctrlGl_Paint);
            ctrlGl.Resize += new EventHandler(ctrlGl_Resize);
            TimRender.Tick += new EventHandler(TimRender_Tick);

            this.Show();
            Texturas.LoadTextura("Logo", Application.StartupPath + @"\Recursos\Imagens\Logo.png");
            Fontes.LoadFonte("FPS", "Arial Black", 16);
            Fontes.LoadFonte("Carregando", "Arial Black", 16);
            //Inicializa o DirectSound
            Sons.Inicializar(this.Handle);

            TimRender.Start();
            refTick = Environment.TickCount;
        }

        void Blocos_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (EstadoJogo)
            {
                case EstadosJogo.MENU:
                    if (MenuItens.Itens[MenuItens.Selecionado].Funcao == "EscreverNome")
                    {
                        MenuItem item = MenuItens.Itens[MenuItens.Selecionado];
                        //Processa Digitos
                        if ((char.IsLetterOrDigit(e.KeyChar) ||
                             char.IsPunctuation(e.KeyChar) ||
                             char.IsWhiteSpace(e.KeyChar)) &&
                             e.KeyChar != (char)13 &&
                             item.Texto.Length < 20)
                        {
                            Sons.GetSom("MudancaMenu").Play(BufferPlayFlags.Default);
                            item.Texto += e.KeyChar;
                            MenuItens.Itens[MenuItens.Selecionado + 1].Enabled = true;
                        }
                        else if (e.KeyChar == (char)8 && item.Texto.Length > 0)
                        {
                            Sons.GetSom("MudancaMenu").Play(BufferPlayFlags.Default);
                            item.Texto = item.Texto.Remove(item.Texto.Length - 1);
                            if (item.Texto.Length == 0)
                                MenuItens.Itens[MenuItens.Selecionado + 1].Enabled = false;
                        }
                    }
                    break;
            }
        }

        void Blocos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (EstadoJogo)
            {
                case EstadosJogo.INTRODUCAO:
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                        case Keys.Escape:
                            Render.Carregar();
                            break;
                    }
                    break;
                case EstadosJogo.MENU:
                    switch (e.KeyCode)
                    {
                        case Keys.Enter:
                            if (MenuItens.Itens[MenuItens.Selecionado].Enabled)
                                ExecFuncItemMenu(MenuItens.Itens[MenuItens.Selecionado].Funcao);
                            break;
                        case Keys.Delete:
                            if (MenuItens.Menu == "Saves")
                            {
                                try
                                {
                                    int numSave = int.Parse((MenuItens.Itens[MenuItens.Selecionado].Funcao.Remove(0, "SelecSave:".Length)));
                                    if (File.Exists(Application.StartupPath + @"\Saves\Save " + numSave + ".sav"))
                                    {
                                        SaveGame.Numero = numSave;
                                        MenuItens.AbrirMenu("Apagar Save");
                                    }
                                }
                                catch { }
                            }
                            break;
                    }
                    break;
                case EstadosJogo.JOGO:
                    switch (e.KeyCode)
                    {
                        case Keys.Escape:
                            EstadoJogo = EstadosJogo.MENU;
                            break;
                        case Keys.Enter:
                            if (SubEstadoJogo == (SubEstadosJogo.BAIRRO | SubEstadosJogo.LIVRE))
                            {
                                PredioConstruc = new Predio(0, TipoPredioSelec);
                                Guindaste.Andar = new Andar(0, 0, 0, Texturas.GetTextura(string.Format("Andar {0} Porta", TipoPredioSelec.ToString())));
                                Andares.Add(Guindaste.Andar);
                                AlturaCamera = 1000;
                                SubEstadoJogo = SubEstadosJogo.CONSTRUINDO;
                                SaveGame.Tutorial = false; //Desabilita a mensagem tutorial
                                MenuItens.Itens[0].Enabled = true; //Habilita a opção "Continuar"
                            }
                            else if (SubEstadoJogo == SubEstadosJogo.CONSTRUINDO)
                            {
                                Andar andar = Guindaste.Andar;
                                if (andar != null)
                                {
                                    Guindaste.Andar = null;

                                    andar.Caindo = true;
                                    andar.VelX = 400;
                                    if (!Guindaste.DirecDir)
                                        andar.VelX *= -1;
                                    andar.VelY = -250;
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (EstadoJogo)
            {
                case EstadosJogo.MENU:
                    switch (keyData)
                    {
                        case Keys.Up:
                            Sons.GetSom("MudancaMenu").Play(BufferPlayFlags.Default);
                            MenuItens.Selecionado = (MenuItens.Selecionado - 1);
                            if (MenuItens.Selecionado < 0)
                                MenuItens.Selecionado = MenuItens.Itens.Count - 1;
                            break;
                        case Keys.Down:
                            Sons.GetSom("MudancaMenu").Play(BufferPlayFlags.Default);
                            MenuItens.Selecionado = (MenuItens.Selecionado + 1) % MenuItens.Itens.Count;
                            break;
                    }
                    break;
                case EstadosJogo.JOGO:
                    if (SubEstadoJogo == (SubEstadosJogo.BAIRRO | SubEstadosJogo.LIVRE))
                    {
                        switch (keyData)
                        {
                            case Keys.Up:
                                Sons.GetSom("MudancaMenu").Play(BufferPlayFlags.Default);
                                TipoPredioSelec -= 1;

                                if ((int)TipoPredioSelec < 1)
                                    TipoPredioSelec = TipoPredio.Amarelo;

                                if (SaveGame.QtdeMoradores < 3500 && TipoPredioSelec == TipoPredio.Amarelo)
                                TipoPredioSelec = TipoPredio.Verde;
                                if (SaveGame.QtdeMoradores < 1000 && TipoPredioSelec == TipoPredio.Verde)
                                TipoPredioSelec = TipoPredio.Vermelho;
                                if (SaveGame.QtdeMoradores < 300 && TipoPredioSelec == TipoPredio.Vermelho)
                                TipoPredioSelec = TipoPredio.Azul;

                                break;
                            case Keys.Down:
                                Sons.GetSom("MudancaMenu").Play(BufferPlayFlags.Default);
                                TipoPredioSelec = (TipoPredio)(((int)TipoPredioSelec + 1) % 5);

                                if (SaveGame.QtdeMoradores < 3500 && TipoPredioSelec == TipoPredio.Amarelo ||
                                    SaveGame.QtdeMoradores < 1000 && TipoPredioSelec == TipoPredio.Verde ||
                                    SaveGame.QtdeMoradores < 300 && TipoPredioSelec == TipoPredio.Vermelho ||
                                    TipoPredioSelec == TipoPredio.Vazio)
                                    TipoPredioSelec = TipoPredio.Azul;

                                break;
                        }
                    }
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void ExecFuncItemMenu(string NomeFuncao)
        {
            if (NomeFuncao == "Application.Exit")
                Application.Exit();
            else if (NomeFuncao.StartsWith("AbrirMenu:"))
                MenuItens.AbrirMenu(NomeFuncao.Remove(0, "AbrirMenu:".Length));
            else if (NomeFuncao.StartsWith("SelecSave:"))
            {
                int NumSave = int.Parse(NomeFuncao.Remove(0, "SelecSave:".Length));
                SaveGame.Numero = NumSave;

                if (File.Exists(Application.StartupPath + @"\Saves\Save " + NumSave + ".sav"))
                {
                    SaveGame.Carregar(NumSave);
                    MenuItens.AbrirMenu("Principal");
                }
                else
                    MenuItens.AbrirMenu("Criar Save");

            }
            else if (NomeFuncao == "CriarSave")
            {
                string nome = "";
                foreach (MenuItem item in MenuItens.Itens)
                {
                    if (item.Funcao == "EscreverNome")
                        nome = item.Texto;
                }
                SaveGame.Reset();
                SaveGame.Nome = nome;
                SaveGame.Salvar(SaveGame.Numero);
                MenuItens.AbrirMenu("Principal");

            }
            else if (NomeFuncao == "NovoJogo")
            {
                SaveGame.Reset();
                SaveGame.Salvar(SaveGame.Numero);
                SaveGame.Tutorial = true;
                MenuItens.Itens[0].Enabled = true; //Desabilita a opção "Continuar"
                Andares.Clear();
                Guindaste.Andar = null;
                SubEstadoJogo = SubEstadosJogo.BAIRRO | SubEstadosJogo.LIVRE;
                EstadoJogo = EstadosJogo.JOGO;
            }
            else if (NomeFuncao == "ContinuarJogo")
                EstadoJogo = EstadosJogo.JOGO;
            else if (NomeFuncao == "SaveGame.Salvar")
                SaveGame.Salvar(SaveGame.Numero);
            else if (NomeFuncao.StartsWith("SaveGame.Apagar:"))
            {
                int NumSave = int.Parse(NomeFuncao.Remove(0, "SaveGame.Apagar:".Length));
                string nomeArq = Application.StartupPath + @"\Saves\Save " + NumSave + ".sav";
                if (File.Exists(nomeArq))
                    File.Delete(nomeArq);
                MenuItens.AbrirMenu("Saves");
            }
        }

        void ctrlGl_Paint(object sender, PaintEventArgs e)
        {
            int Tick = Environment.TickCount;
            float Avanco = Math.Min((Tick - ultTick) / 1000f, 0.5f);
            ultTick = Tick;
            Tick -= refTick;

            FPS.Registrar(Tick);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            switch (EstadoJogo)
            {
                case EstadosJogo.INTRODUCAO:
                    Render.RenderIntroducao(Tick);
                    break;
                case EstadosJogo.CARREGANDO:
                    Render.RenderCarregando(Tick);
                    break;
                case EstadosJogo.MENU:
                    Render.RenderMenu(Tick, Avanco);
                    break;
                case EstadosJogo.JOGO:
                    Render.RenderJogo(Tick, Avanco);
                    break;
            }

            Fonte fonte = Fontes.GetFonte("FPS");
            Fontes.DrawString(string.Format("{0:0} FPS", FPS.Media), fonte, Color.Yellow, true, 0, Screen.Height - fonte.Height + 5);

            Gl.glFlush();
        }

        void TimRender_Tick(object sender, EventArgs e)
        {
            ctrlGl.Invalidate();
        }

        void Blocos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ctrlGl != null)
                ctrlGl.DestroyContexts();
        }

        void ctrlGl_Resize(object sender, EventArgs e)
        {
            Screen.Size = ctrlGl.Size;
            //Screen.Size = new Size(ctrlGl.Size.Width * 4, ctrlGl.Size.Height * 4);
            ResetOpenGl();
        }

        void ResetOpenGl()
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glViewport(0, 0, Screen.Width, Screen.Height);
            //Gl.glViewport(0, 0, this.Width, this.Height);
            Gl.glOrtho(0, Screen.Width, 0, Screen.Height, -1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        void InitOpenGl()
        {
            Cursor.Hide();

            Gl.glClearColor(0, 0, 0, 1);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_FASTEST);

            ResetOpenGl();
        }

        internal enum EstadosJogo
        {
            INTRODUCAO,
            CARREGANDO,
            MENU,
            CRIARSAVE,
            JOGO,
            CONSTRUINDO
        }

        internal enum SubEstadosJogo
        {
            BAIRRO = 1,
            CONSTRUINDO = 2,
            //Componentes do BAIRRO
            LIVRE = 4,
            ESCOLHENDO_SLOT = 8,
            //Componentes do CONSTRUINDO
            CONCLUIDO = 16
        }

        internal enum TipoPredio
        {
            Vazio,
            Azul,
            Vermelho,
            Verde,
            Amarelo
        }
    }
}