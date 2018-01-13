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
    public partial class FrmVistaT3 : Form
    {
        PictureBox ImgProcurado = new PictureBox();
        Label LblAcerto = new Label();

        public FrmVistaT3()
        {
            InitializeComponent();

            LblAcerto.Parent = this;
            LblAcerto.Size = new Size(2, 2);
            LblAcerto.BackColor = Color.Gray;
            LblAcerto.BorderStyle = BorderStyle.None;
            LblAcerto.BringToFront();
            LblAcerto.Click += new EventHandler(LblAcerto_Click);

            ImgProcurado.Parent = this;
            ImgProcurado.Size = new Size(512, 512);
            Bitmap imagem = new Bitmap(512, 512);
            for (int x = 0; x < imagem.Width; x++)
                for (int y = 0; y < imagem.Height; y++)
                {
                    int cor = 255 - ((x + y) % 2 * 255);
                    imagem.SetPixel(x, y, Color.FromArgb(cor, cor, cor));
                }
            ImgProcurado.Image = imagem;
        }

        void LblAcerto_Click(object sender, EventArgs e)
        {
            FrmVistaT1.acertos++;
            TimAtualizarTempo.Stop();
            FrmMenu.FrmMain.TimTempoCountStatus(false);
            MessageBox.Show("Achou!");
            FrmVistaT4 inst = new FrmVistaT4();
            inst.Show();
            Dispose();
        }

        private void FrmVistaT2_SizeChanged(object sender, EventArgs e)
        {
            Random rdn = new Random();
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, ImgProcurado.Location.Y / 2 - LblInformacao.Height / 2);
            ImgProcurado.Location = new Point(this.Width / 2 - ImgProcurado.Width / 2, this.Height / 2 - ImgProcurado.Height / 2);
            LblAcerto.Location = new Point(ImgProcurado.Location.X + rdn.Next(0, ImgProcurado.Width), ImgProcurado.Location.Y + rdn.Next(0, ImgProcurado.Height));
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
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
            FrmVistaT4 inst = new FrmVistaT4();
            inst.Show();
            Dispose();
        }

        private void FrmVistaT2_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo.Start();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void FrmVistaT3_FormClosing(object sender, FormClosingEventArgs e)
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
