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
    public partial class FrmVistaT2 : Form
    {
        public FrmVistaT2()
        {
            InitializeComponent();
            FrmMenu.FrmMain.TimTempoCountStatus(true);
            Point dif = new Point(Math.Abs(LblCerto.Location.X - LblLetras.Location.X), Math.Abs(LblCerto.Location.Y - LblLetras.Location.Y));
            LblCerto.Parent = LblLetras;
            LblCerto.Location = new Point(dif.X, dif.Y);
        }

        private void FrmVistaT3_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo.Start();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
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

        private void FrmVistaT3_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            LblLetras.Location = new Point(this.Width / 2 - LblLetras.Width / 2, this.Height / 2 - LblLetras.Height / 2);
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, LblLetras.Location.Y / 2 - LblInformacao.Height / 2);
        }

        private void LblCerto_Click(object sender, EventArgs e)
        {
            FrmVistaT1.acertos++;
            FrmVistaT3 inst = new FrmVistaT3();
            inst.Show();
            Dispose();
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            FrmVistaT3 inst = new FrmVistaT3();
            inst.Show();
            Dispose();
        }

        private void FrmVistaT2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
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
