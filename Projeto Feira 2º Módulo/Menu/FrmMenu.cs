using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Menu.Properties;
using System.Runtime.InteropServices;

namespace Menu
{
    public partial class FrmMenu : Form
    {
        [DllImport("user32.dll")]
        static extern short GetKeyState(Keys KeyID);
        
        public static bool Pass1, Pass2, Pass4;
        public static FrmMenu FrmMain;
        public static int tempoCount = 1200;
        public bool iniciou;

        public FrmMenu()
        {
            InitializeComponent();
            FrmMain = this;
            LblInfo.Text = null;
            ImgCadeado.Location = new Point(Img3.Width / 2 - ImgCadeado.Width / 2, Img3.Height / 2 - ImgCadeado.Height / 2);
            ImgCadeado.Parent = Img3;
        }

        private void FrmMenu_SizeChanged(object sender, EventArgs e)
        {
            Img1.Location = new Point(this.Width / 2 - Img1.Height / 2, this.Height / 2 - (Img1.Height + Img1.Height / 2));
            Img2.Location = new Point(this.Width / 2 + Img2.Width / 2, this.Height / 2 - Img2.Height / 2);
            Img3.Location = new Point(this.Width / 2 - Img3.Height / 2, this.Height / 2 + Img3.Height / 2);
            Img4.Location = new Point(this.Width / 2 - Img4.Width / 2 - Img4.Width, this.Height / 2 - Img4.Height / 2);
            LblInfo.Location = new Point(this.Width / 2 - LblInfo.Width / 2, this.Height / 2 - LblInfo.Height / 2);
            BtnParar.Location = new Point(0, this.Height - BtnParar.Height);
            LblTempo.Location = new Point(12, 12);
        }

        private void Img1_MouseEnter(object sender, EventArgs e)
        {
            LblInfo.Text = "C.F.C.";
            if (Pass1)
                return;
            Img1.Image = Resources.ImgCFC1;
        }

        private void Img1_MouseLeave(object sender, EventArgs e)
        {
            LblInfo.Text = null;
            if (Pass1)
                return;
            Img1.Image = Resources.ImgCFC0;
        }

        private void Img1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Pass1)
                return;
            Img1.Image = Resources.ImgCFC128;
        }

        private void Img1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Pass1)
                return;
            IniciarTeste();
            FrmCFC inst = new FrmCFC();
            inst.Show();
            Hide();
        }

        private void Img2_MouseEnter(object sender, EventArgs e)
        {
            LblInfo.Text = "Teste Psicotécnico";
            if (Pass2)
                return;
            Img2.Image = Resources.ImgPisic1;
        }

        private void Img2_MouseLeave(object sender, EventArgs e)
        {
            LblInfo.Text = null;
            if (Pass2)
                return;
            Img2.Image = Resources.ImgPisic0;
        }

        private void Img2_MouseDown(object sender, MouseEventArgs e)
        {
            if (Pass2)
                return;
            Img2.Image = Resources.ImgPisic128;
        }

        private void Img2_MouseUp(object sender, MouseEventArgs e)
        {
            if (Pass2)
                return;
            IniciarTeste();
            FrmPsicT1 inst = new FrmPsicT1();
            inst.Show();
            Hide();
        }

        private void Img3_MouseEnter(object sender, EventArgs e)
        {
            LblInfo.Text = "Teste Prático";
            if (ImgCadeado.Visible)
                return;
            Img3.Image = Resources.ImgVolante1;
        }

        private void Img3_MouseLeave(object sender, EventArgs e)
        {
            LblInfo.Text = null;
            if (ImgCadeado.Visible)
                return;
            Img3.Image = Resources.ImgVolante0;
        }

        private void Img3_MouseDown(object sender, MouseEventArgs e)
        {
            if (ImgCadeado.Visible)
                return;
            Img3.Image = Resources.ImgVolante128;
        }

        private void Img4_MouseEnter(object sender, EventArgs e)
        {
            LblInfo.Text = "Teste de Vista";
            if (Pass4)
                return;
            Img4.Image = Resources.ImgVista1;
        }

        private void Img4_MouseDown(object sender, MouseEventArgs e)
        {
            if (Pass4)
                return;
            Img4.Image = Resources.ImgVista128;
        }

        private void Img4_MouseLeave(object sender, EventArgs e)
        {
            LblInfo.Text = null;
            if (Pass4)
                return;
            Img4.Image = Resources.ImgVista0;
        }

        private void Img4_MouseUp(object sender, MouseEventArgs e)
        {
            if (Pass4)
                return;
            IniciarTeste();
            FrmVistaT1 inst = new FrmVistaT1();
            inst.Show();
            Hide();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (Pass1)
                Img1.Image = Resources.Certo;
            if (Pass2)
                Img2.Image = Resources.Certo;
            if (Pass4)
                Img4.Image = Resources.Certo;
            ImgCadeado.Visible = !(Pass1 && Pass2 && Pass4);
        }

        public void PararTeste()
        {
            Pass1 = false;
            Pass2 = false;
            Pass4 = false;
            Img1.Image = Resources.ImgCFC0;
            Img2.Image = Resources.ImgPisic0;
            Img4.Image = Resources.ImgVista0;
            ImgCadeado.Visible = true;
            TimTempoCount.Stop();
            tempoCount = 1200;
            BtnParar.Visible = false;
            iniciou = false;
        }

        private void TimTempoCount_Tick(object sender, EventArgs e)
        {
            FrmMenu.tempoCount--;
            if (FrmMenu.tempoCount <= 0)
            {
                TimTempoCount.Stop();
                MessageBox.Show("Fim da Prova");
            }
        }

        public void TimTempoCountStatus(bool status)
        {
            if (status)
                TimTempoCount.Start();
            else
                TimTempoCount.Stop();
        }

        private void TimAtualizarTempo_Tick(object sender, EventArgs e)
        {
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
            if (!(GetKeyState(Keys.LControlKey) == 1 || GetKeyState(Keys.LControlKey) == 0) &&
                !(GetKeyState(Keys.LShiftKey) == 1 || GetKeyState(Keys.LShiftKey) == 0) &&
                !(GetKeyState(Keys.Q) == 1 || GetKeyState(Keys.Q) == 0) &&
                this.Visible)
                Dispose();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo_Tick(null, null);
        }

        private void IniciarTeste()
        {
            TimTempoCount.Start();
            iniciou = true;
            BtnParar.Visible = true;
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            if (iniciou)
                if (MessageBox.Show("Tem certeza de que deseja desistir de tirar carta de motorista?", "Atensão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    PararTeste();
        }

        private void ImgCadeado_MouseEnter(object sender, EventArgs e)
        {
            LblInfo.Text = "Passe nos outros testes para desbloquear o teste prático";
        }

        private void Img3_MouseUp(object sender, MouseEventArgs e)
        {
            GC.Collect();
            if (ImgCadeado.Visible)
            {
                TimPosVolante.Start();
                ImgCadeado.Visible = true;
                //System.Diagnostics.Process.Start("DriverTest_Demo.exe");
            }
        }

        private void TimPosVolante_Tick(object sender, EventArgs e)
        {
            PararTeste();
            TimPosVolante.Stop();
        }
    }
}