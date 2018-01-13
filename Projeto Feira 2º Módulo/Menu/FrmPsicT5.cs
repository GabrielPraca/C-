using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Menu.Properties;

namespace Menu
{
    public partial class FrmPsicT5 : Form
    {
        int acertos = 0, status = 0;
        public FrmPsicT5()
        {
            InitializeComponent();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void checar()
        {
            if (status == 1)
            {
                if (acertos == 2)
                    FrmPsicT1.acertos++;
                BtnProx.PerformClick();
                return;
            }
            BackColor = Color.DarkViolet;
            Pb1.Image = Resources._01;
            Pb2.Visible = true;
            Pb3.Image = Resources._03;
            Pb4.Image = Resources._04;
            Pb5.Image = Resources._05;
            Pb6.Image = Resources._06;
            Pb7.Visible = true;
            Pb8.Image = Resources._08; 
            PbPrinc.Image = Resources.princ2;
            status++;
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            checar();
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            checar();
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            checar();
        }

        private void Pb4_Click(object sender, EventArgs e)
        {
            if (status == 1)
                acertos++;
            checar();
        }

        private void Pb5_Click(object sender, EventArgs e)
        {
            checar();
        }

        private void Pb6_Click(object sender, EventArgs e)
        {
            if (status == 0)
                acertos++;
            checar();
        }

        private void Pb7_Click(object sender, EventArgs e)
        {
            checar();
        }

        private void Pb8_Click(object sender, EventArgs e)
        {
            checar();
        }

        private void FrmPsicT5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmPsicT5_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, PbPrinc.Location.Y / 2 - LblInformacao.Height / 2);
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

        private void BtnProx_Click(object sender, EventArgs e)
        {
            FrmMenu.FrmMain.TimTempoCountStatus(false);
            FrmPsicFim inst = new FrmPsicFim();
            inst.Show();
            Dispose();
        }
    }
}