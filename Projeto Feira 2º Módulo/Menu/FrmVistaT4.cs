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
    public partial class FrmVistaT4 : Form
    {
        int acertos = 0;
        public FrmVistaT4()
        {
            InitializeComponent();
            FrmMenu.FrmMain.TimTempoCountStatus(true);
        }

        private void FrmVistaT4_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            ImgE.Location = new Point(this.Width / 2 - ImgH.Width * 2 - 12, this.Height / 2 - ImgE.Height / 2);
            ImgH.Location = new Point(this.Width / 2 - ImgH.Width / 2, this.Height / 2 - ImgH.Height / 2);
            ImgZ.Location = new Point(this.Width / 2 + ImgH.Width + 12, this.Height / 2 - ImgZ.Height / 2);
            TxtE.Location = new Point(ImgE.Location.X + ImgE.Width / 2 - TxtE.Width / 2, ImgE.Location.Y + ImgE.Height + 12);
            TxtH.Location = new Point(ImgH.Location.X + ImgH.Width / 2 - TxtH.Width / 2, ImgH.Location.Y + ImgH.Height + 12);
            TxtZ.Location = new Point(ImgZ.Location.X + ImgZ.Width / 2 - TxtZ.Width / 2, ImgZ.Location.Y + ImgZ.Height + 12);
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, ImgE.Location.Y / 2 - LblInformacao.Height / 2);
            LblTempo.Location = new Point(12, 12);
        }

        private void FrmVistaT4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
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

        private void BtnProx_Click(object sender, EventArgs e)
        {
            if (TxtE.Text == "E")
                acertos++;
            if (TxtH.Text == "H")
                acertos++;
            if (TxtZ.Text == "Z")
                acertos++;
            TimAtualizarTempo.Stop();
            FrmMenu.FrmMain.TimTempoCountStatus(false);
            if (acertos > 1)
                FrmVistaT1.acertos++;
            FrmVistaT5 inst = new FrmVistaT5();
            inst.Show();
            Dispose();
        }

        private void FrmVistaT4_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo.Start();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void TxtE_TextChanged(object sender, EventArgs e)
        {
            TxtE.Text = TxtE.Text.ToUpper();
            TxtE.Select(TxtE.Text.Length, TxtE.Text.Length);
        }

        private void TxtH_TextChanged(object sender, EventArgs e)
        {
            TxtH.Text = TxtH.Text.ToUpper();
            TxtH.Select(TxtH.Text.Length, TxtH.Text.Length);
        }

        private void TxtZ_TextChanged(object sender, EventArgs e)
        {
            TxtZ.Text = TxtZ.Text.ToUpper();
            TxtZ.Select(TxtZ.Text.Length, TxtZ.Text.Length);
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
