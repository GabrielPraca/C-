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
    public partial class FrmCFCFim : Form
    {
        public FrmCFCFim()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            int porc = (FrmCFC.acertos * 100 / 15);
            FrmCFC.acertos = 0;
            LblAcertos.Text = "Acertou " + porc + "%";
            if (porc >= 70)
            {
                LblResult.ForeColor = Color.LimeGreen;
                LblResult.Text = "Aprovado!";
                FrmMenu.Pass1 = true;
            }
            else
            {
                TimHabBtn.Interval = 10000;
                LblResult.Text = "Reprovado!";
                FrmMenu.FrmMain.PararTeste();
            }
            TimHabBtn.Start();
        }

        private void FrmCFCFim_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmCFCFim_SizeChanged(object sender, EventArgs e)
        {
            Lbltitulo.Location = new Point(this.Width / 2 - Lbltitulo.Width / 2, 30);
            LblInfoPass.Location = new Point(this.Width / 2 - LblInfoPass.Width / 2, Lbltitulo.Location.Y + Lbltitulo.Height + 20);
            LblResult.Location = new Point(this.Width / 2 - LblResult.Width / 2, this.Height / 2 - LblResult.Height / 2);
            LblAcertos.Location = new Point(this.Width / 2 - LblAcertos.Width / 2, LblResult.Location.Y + LblResult.Height + 12);
            BtnMenu.Location = new Point(this.Width - BtnMenu.Width - 12, this.Height - BtnMenu.Height - 12);
        }

        private void TimHabBtn_Tick(object sender, EventArgs e)
        {
            BtnMenu.Enabled = true;
            TimHabBtn.Stop();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (LblResult.Text == "Aprovado!")
                FrmMenu.FrmMain.TimTempoCountStatus(true);
            FrmMenu.FrmMain.Show();
            Dispose();
        }
    }
}
