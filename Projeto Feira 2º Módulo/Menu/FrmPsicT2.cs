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
    public partial class FrmPsicT2 : Form
    {
        PictureBox[] ImgCarteira = new PictureBox[10];
        int[,] direcao = new int[10, 2];
        int quant;

        public FrmPsicT2()
        {
            InitializeComponent();
            LblFundoKick.Size = new Size(640, 512);
            Random rdm = new Random();
            quant = rdm.Next(4) + 4;
            for (int i = 0; i < quant; i++)
            {
                ImgCarteira[i] = new PictureBox();
                ImgCarteira[i].Parent = LblFundoKick;
                ImgCarteira[i].Size = new Size(128, 93);
                ImgCarteira[i].Location = new Point(rdm.Next(LblFundoKick.Width - ImgCarteira[i].Width), rdm.Next(LblFundoKick.Height - ImgCarteira[i].Height));
                ImgCarteira[i].SizeMode = PictureBoxSizeMode.StretchImage;
                ImgCarteira[i].Image = Resources.Carteira;
                direcao[i, 0] = rdm.Next(6) + 5;
                direcao[i, 1] = rdm.Next(6) + 5;
            }
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void FrmPsicT2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmPsicT2_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            LblFundoKick.Location = new Point(this.Width / 2 - LblFundoKick.Width / 2, this.Height / 2 - LblFundoKick.Height / 2);
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, LblFundoKick.Location.Y / 2 - LblInformacao.Height / 2);
            Rdb4.Location = new Point(LblFundoKick.Location.X, LblFundoKick.Location.Y - 12 - Rdb4.Height / 2);
            Rdb5.Location = new Point(LblFundoKick.Location.X + Convert.ToInt32(LblFundoKick.Width * 0.35) - Rdb5.Width / 2, LblFundoKick.Location.Y - 12 - Rdb5.Height / 2);
            Rdb6.Location = new Point(LblFundoKick.Location.X + Convert.ToInt32(LblFundoKick.Width * 0.65) - Rdb6.Width / 2, LblFundoKick.Location.Y - 12 - Rdb6.Height / 2);
            Rdb7.Location = new Point(LblFundoKick.Location.X + LblFundoKick.Width - Rdb7.Width, LblFundoKick.Location.Y - 12 - Rdb7.Height / 2);
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
            int marcado = 0;
            if (Rdb4.Checked)
                marcado = 4;
            if (Rdb5.Checked)
                marcado = 5;
            if (Rdb6.Checked)
                marcado = 6;
            if (Rdb7.Checked)
                marcado = 7;
            if (quant == marcado)
                FrmPsicT1.acertos++;
            FrmPsicT3 inst = new FrmPsicT3();
            inst.Show();
            Dispose();
        }

        private void TimAnim_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (ImgCarteira[i] == null)
                    return;
                int x, y;
                x = ImgCarteira[i].Location.X + direcao[i, 0];
                y = ImgCarteira[i].Location.Y + direcao[i, 1];
                if (x < 0)
                {
                    x = 0;
                    direcao[i, 0] *= -1;
                }
                else if (x > LblFundoKick.Width - ImgCarteira[i].Width)
                {
                    x = LblFundoKick.Width - ImgCarteira[i].Width;
                    direcao[i, 0] *= -1;
                }
                if (y < 0)
                {
                    y = 0;
                    direcao[i, 1] *= -1;
                }
                else if (y > LblFundoKick.Height - ImgCarteira[i].Height)
                {
                    y = LblFundoKick.Height - ImgCarteira[i].Height;
                    direcao[i, 1] *= -1;
                }
                ImgCarteira[i].Location = new Point(x, y);
            }
        }
    }
}
