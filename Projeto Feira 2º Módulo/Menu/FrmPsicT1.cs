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
    public partial class FrmPsicT1 : Form
    {
        public static int acertos = 0; 
        int pecCerta = 1;

        private int[] RandomNO54(Random rdm)
        {
            int[] num = new int[2];
            num[0] = rdm.Next(5) + 1;
            num[1] = rdm.Next(5) + 1;
            while ((num[0] == 4 && num[1] == 5) || (num[0] == 5 && num[1] == 4))
            {
                num[0] = rdm.Next(5) + 1;
                num[1] = rdm.Next(5) + 1;
            }
            return num;
        }

        public FrmPsicT1()
        {
            int v1, v2;
            InitializeComponent();
            Random rdm = new Random();
            pecCerta = rdm.Next(5) + 1;
            int[] varray = new int[2];
            varray = RandomNO54(rdm);
            v1 = varray[0];
            v2 = varray[1];
            Img11.Image = LoadBmpPeca(v1);
            Img12.Image = LoadBmpPeca(v2);
            Rdb1.Text = v1 + "|" + v2;
            varray = RandomNO54(rdm);
            v1 = varray[0];
            v2 = varray[1];
            Img21.Image = LoadBmpPeca(v1);
            Img22.Image = LoadBmpPeca(v2);
            Rdb2.Text = v1 + "|" + v2;
            varray = RandomNO54(rdm);
            v1 = varray[0];
            v2 = varray[1];
            Img31.Image = LoadBmpPeca(v1);
            Img32.Image = LoadBmpPeca(v2);
            Rdb3.Text = v1 + "|" + v2;
            varray = RandomNO54(rdm);
            v1 = varray[0];
            v2 = varray[1];
            Img41.Image = LoadBmpPeca(v1);
            Img42.Image = LoadBmpPeca(v2);
            Rdb4.Text = v1 + "|" + v2;
            varray = RandomNO54(rdm);
            v1 = varray[0];
            v2 = varray[1];
            Img51.Image = LoadBmpPeca(v1);
            Img52.Image = LoadBmpPeca(v2);
            Rdb5.Text = v1 + "|" + v2;
            if (pecCerta == 1)
            {
                Img11.Image = LoadBmpPeca(4);
                Img12.Image = LoadBmpPeca(5);
                Rdb1.Text = "4|5";
            }
            else if (pecCerta == 2)
            {
                Img21.Image = LoadBmpPeca(4);
                Img22.Image = LoadBmpPeca(5);
                Rdb2.Text = "4|5";
            }
            else if (pecCerta == 3)
            {
                Img31.Image = LoadBmpPeca(4);
                Img32.Image = LoadBmpPeca(5);
                Rdb3.Text = "4|5";
            }
            else if (pecCerta == 4)
            {
                Img41.Image = LoadBmpPeca(4);
                Img42.Image = LoadBmpPeca(5);
                Rdb4.Text = "4|5";
            }
            else if (pecCerta == 5)
            {
                Img51.Image = LoadBmpPeca(4);
                Img52.Image = LoadBmpPeca(5);
                Rdb5.Text = "4|5";
            }
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private Bitmap LoadBmpPeca(int id)
        {
            Bitmap retorno = new Bitmap(64, 64);;
            switch (id)
            {
                case 1:
                    retorno = Resources.Peça1;
                    break;
                case 2:
                    retorno = Resources.Peça2;
                    break;
                case 3:
                    retorno = Resources.Peça3;
                    break;
                case 4:
                    retorno = Resources.Peça4;
                    break;
                case 5:
                    retorno = Resources.Peça5;
                    break;
                case 6:
                    retorno = Resources.Peça6;
                    break;
            }
            return retorno;
        }

        private void FrmPsicT1_SizeChanged(object sender, EventArgs e)
        {
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, 40);
            ImgDomino.Location = new Point(this.Width / 2 - ImgDomino.Width / 2, Convert.ToInt32(this.Height * 0.40) - ImgDomino.Height / 2);
            Img31.Location = new Point(this.Width / 2 - Img11.Width / 2, ImgDomino.Location.Y + ImgDomino.Height + 12);
            Img21.Location = new Point(this.Width / 2 - Img11.Width / 2 - 12 - Img11.Width, ImgDomino.Location.Y + ImgDomino.Height + 12);
            Img41.Location = new Point(this.Width / 2 + Img11.Width / 2 + 12, ImgDomino.Location.Y + ImgDomino.Height + 12);
            Img51.Location = new Point(this.Width / 2 + Img11.Width / 2 + 12 + Img11.Width + 12, ImgDomino.Location.Y + ImgDomino.Height + 12);
            Img11.Location = new Point(this.Width / 2 - Img11.Width / 2 - 12 - Img11.Width - 12 - Img11.Width, ImgDomino.Location.Y + ImgDomino.Height + 12);
            Img12.Location = new Point(Img11.Location.X, Img11.Location.Y + Img12.Height - 2);
            Img22.Location = new Point(Img21.Location.X, Img21.Location.Y + Img22.Height - 2);
            Img32.Location = new Point(Img31.Location.X, Img31.Location.Y + Img32.Height - 2);
            Img42.Location = new Point(Img41.Location.X, Img41.Location.Y + Img42.Height - 2);
            Img52.Location = new Point(Img51.Location.X, Img51.Location.Y + Img52.Height - 2);
            Rdb1.Location = new Point(Img12.Location.X + Img12.Width / 2 - Rdb1.Width / 2, Img12.Location.Y + Img12.Height + 12);
            Rdb2.Location = new Point(Img22.Location.X + Img12.Width / 2 - Rdb2.Width / 2, Img12.Location.Y + Img12.Height + 12);
            Rdb3.Location = new Point(Img32.Location.X + Img12.Width / 2 - Rdb3.Width / 2, Img12.Location.Y + Img12.Height + 12);
            Rdb4.Location = new Point(Img42.Location.X + Img12.Width / 2 - Rdb4.Width / 2, Img12.Location.Y + Img12.Height + 12);
            Rdb5.Location = new Point(Img52.Location.X + Img12.Width / 2 - Rdb5.Width / 2, Img12.Location.Y + Img12.Height + 12);
            LblFundoCor.Location = new Point(Img11.Location.X - 12, Img11.Location.Y - 12);
            LblFundoCor.Size = new Size(Img11.Width * 5 + 12 * 6, 12 * 3 + 128 + Rdb1.Height);
            LblFundoCor.SendToBack();
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            
        }

        private void FrmPsicT1_FormClosing(object sender, FormClosingEventArgs e)
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
            if (Rdb1.Checked)
                marcado = 1;
            if (Rdb2.Checked)
                marcado = 2;
            if (Rdb3.Checked)
                marcado = 3;
            if (Rdb4.Checked)
                marcado = 4;
            if (Rdb5.Checked)
                marcado = 5;
            if (marcado == pecCerta)
                acertos++;
            FrmPsicT2 inst = new FrmPsicT2();
            inst.Show();
            Dispose();
        }
    }
}
