using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Navegador.Properties;
using System.Runtime.InteropServices;

namespace Navegador
{
    public partial class FrmNavegador : Form
    {
        [DllImport("user32.dll")]
        static extern short GetKeyState(int numTecla);

        bool podeMudarEndereco = true, webCompleto = false, ContrF11 = true;
            public static string homePage = @"http://www.google.com.br";
        public static Color corPadrao;
        public static FrmNavegador FormNavegador;

        public FrmNavegador()
        {
            InitializeComponent();
            FormNavegador = this;
            corPadrao = TspFerramentas.BackColor;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            WebNavegador.GoBack();
        }

        private void BtnVotar_Click(object sender, EventArgs e)
        {
            WebNavegador.GoForward();
        }

        private bool ProcurarChars(string texto, string caracteres)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == caracteres[0])
                {
                    if (caracteres.Length == 1)
                        return true;
                    else
                    {
                        string comparar = "";
                        if (caracteres.Length >= texto.Length - i + 1)
                            return false;
                        for (int ii = 0; ii < caracteres.Length; ii++)
                            comparar += texto[ii+i];
                        if (comparar == caracteres)
                            return true;
                    }
                }
            }
            return false;
        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            podeMudarEndereco = true;
            try
            {
                TxtEndereco.Text = TxtEndereco.Text.Trim();
                if (!ProcurarChars(TxtEndereco.Text, " ") && (ProcurarChars(TxtEndereco.Text, ".") || ProcurarChars(TxtEndereco.Text, @"file:///")))
                    WebNavegador.Url = new Uri(TxtEndereco.Text);
                else
                {
                    TxtProcura.Text = TxtEndereco.Text;
                    BtnProcurar.PerformClick();
                    TxtProcura.Text = null;
                }

            }
            catch
            {
                string Url = @"http://" + TxtEndereco.Text;
                try
                {
                    WebNavegador.Url = new Uri(Url);
                }
                catch
                {
                    TxtProcura.Text = TxtEndereco.Text;
                    BtnProcurar.PerformClick();
                    TxtProcura.Text = null;
                }
            }
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            WebNavegador.Url = new Uri(TxtEndereco.Text);
        }

        private void TxtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnIr.PerformClick();
            else
                podeMudarEndereco = false;
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            if (MousePosition.Y > this.Top + this.Height - 38)
            {
                if (!TspFerramentas.Visible)
                    TspFerramentas.Visible = true;
            }
            else if (!(TxtEndereco.Focused || TxtProcura.Focused) && MousePosition.Y < (this.Top + this.Height - 50))
                if (TspFerramentas.Visible)
                    TspFerramentas.Visible = false;
        }

        private void TxtProcura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnProcurar.PerformClick();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            podeMudarEndereco = true;
            TxtProcura.Text = TxtProcura.Text.Trim();
            if (TxtProcura.Text != "")
            {
                string strProcura = TxtProcura.Text;
                string strProcurar = "";
                for (int i = 0; i < strProcura.Length; i++)
                {
                    if (strProcura[i] == ' ')
                        strProcurar += '+';
                    else
                        strProcurar += strProcura[i];
                }
                TxtProcura.AutoCompleteCustomSource.Add(TxtProcura.Text);
                WebNavegador.Url = new Uri(@"http://www.google.com.br/search?q=" + strProcurar);
            }
        }

        private void WebNavegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webCompleto = true;
            if (podeMudarEndereco)
                TxtEndereco.Text = WebNavegador.Url.ToString();
            BtnParAtu.Image = Resources.BtnAtualizar;
            BtnParAtu.Text = "Atualizar";
        }

        private void BtnConfigs_Click(object sender, EventArgs e)
        {
            TimTempo.Stop();
            FrmConfigs inst = new FrmConfigs();
            inst.ShowDialog();
            TimTempo.Start();
        }

        public void CorBarFerramentas(Color cor)
        {
            TspFerramentas.BackColor = cor;
        }

        public Color CorBarFerramentas()
        {
            return TspFerramentas.BackColor;
        }

        public string ObterUrlAtual()
        {
            return WebNavegador.Url.ToString();
        }

        private void WebNavegador_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            webCompleto = false;
            BtnParAtu.Image = Resources.BtnParar;
            BtnParAtu.Text = "Parar";
        }

        private void BtnParAtu_Click(object sender, EventArgs e)
        {
            if (!webCompleto)
                WebNavegador.Stop();
            else
            {
                WebNavegador_Navigating(null, null);
                WebNavegador.Refresh();
            }
        }

        private void BtnHome_MouseUp(object sender, MouseEventArgs e)
        {
            if (TimHome3Seg.Enabled)
            {
                TimHome3Seg.Stop();
                TxtEndereco.Text = homePage;
                BtnIr_Click(null, null);
            }
        }

        private void TimHome3Seg_Tick(object sender, EventArgs e)
        {
            TimHome3Seg.Stop();
            if(MessageBox.Show("Tem certeza que deseja definir \"" + WebNavegador.Url.ToString() + "\" como sua pagina inicial?", "D# Browser", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                homePage = WebNavegador.Url.ToString();
        }

        private void BtnHome_MouseDown(object sender, MouseEventArgs e)
        {
            TimHome3Seg.Start();
        }

        private void WebNavegador_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F11 && GetKeyState(122) != 0 && GetKeyState(122) != 1 && ContrF11)
            {
                this.WindowState = FormWindowState.Normal;
                if (this.FormBorderStyle != FormBorderStyle.None)
                    this.FormBorderStyle = FormBorderStyle.None;
                else
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
            }
            ContrF11 = !ContrF11;
        }
    }
}
