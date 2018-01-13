using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmVistaT5 : Form
    {
        int acertos = 0;
        public FrmVistaT5()
        {
            InitializeComponent();
            FrmMenu.FrmMain.TimTempoCountStatus(true);
        }

        private void FrmVistaT5_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo.Start();
            FrmMenu.tempoCount--;
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void FrmVistaT5_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            Img5.Location = new Point(Convert.ToInt32(this.Width / 2 - Img2.Width * 1.5 - 12), this.Height / 2 - Img5.Height / 2);
            Img2.Location = new Point(this.Width / 2 - Img2.Width / 2, this.Height / 2 - Img2.Height / 2);
            Img29.Location = new Point(this.Width / 2 + Img2.Width / 2 + 12, this.Height / 2 - Img29.Height / 2);
            Txt5.Location = new Point(Img5.Location.X + Img5.Width / 2 - Txt5.Width / 2, Img5.Location.Y + Img5.Height + 12);
            Txt2.Location = new Point(Img2.Location.X + Img2.Width / 2 - Txt2.Width / 2, Img2.Location.Y + Img2.Height + 12);
            Txt29.Location = new Point(Img29.Location.X + Img29.Width / 2 - Txt29.Width / 2, Img29.Location.Y + Img29.Height + 12);
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, Img5.Location.Y / 2 - LblInformacao.Height / 2);
            LblTempo.Location = new Point(12, 12);
        }

        private void FrmVistaT5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            if (Txt5.Text == "5")
                acertos++;
            if (Txt2.Text == "2")
                acertos++;
            if (Txt29.Text == "29")
                acertos++;
            TimAtualizarTempo.Stop();
            FrmMenu.FrmMain.TimTempoCountStatus(false);
            if (acertos > 1)
                FrmVistaT1.acertos++;
            FrmVistaFim inst = new FrmVistaFim();
            inst.Show();
            Dispose();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que deseja desistir de tirar carta de motorista?", "Atensão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FrmMenu.FrmMain.PararTeste();
                FrmMenu.FrmMain.Show();
                Dispose();
            }
        }

        private void TimAtualizarTempo_Tick(object sender, EventArgs e)
        {
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
            if (FrmMenu.tempoCount <= 0)
            {
                FrmMenu.FrmMain.Show();
                Dispose();
            }
        }
    }
}
