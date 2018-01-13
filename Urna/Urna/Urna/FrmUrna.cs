using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Urna.Properties;

namespace Urna
{
    public partial class FrmUrna : Form
    {
        string[,] candidatos = {{"Marina", "0"},
                                {"Dilma", "0"},
                                {"José Serra", "0"},
                                {"Tiririca", "0"},
                                {"Arnaldo", "0"},
                                {"Ronaldo", "0"},
                                {"MillHouse", "0"},
                                {"Para Nossa Alegria", "0"}};
        System.Media.SoundPlayer som = new System.Media.SoundPlayer(Resources.urna);

        public FrmUrna()
        {
            InitializeComponent();
            FundSelect.Size = new Size(Img1.Width + 2, Img1.Height + 2);
            FundMarc.Size = new Size(Img1.Width + 2, Img1.Height + 2);
        }

        private void Img1_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img1.Location.X - 1, Img1.Location.Y - 1);
        }

        private void Img2_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img2.Location.X - 1, Img2.Location.Y - 1);
        }

        private void Img3_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img3.Location.X - 1, Img3.Location.Y - 1);
        }

        private void Img4_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img4.Location.X - 1, Img4.Location.Y - 1);
        }

        private void Img5_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img5.Location.X - 1, Img5.Location.Y - 1);
        }

        private void Img6_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img6.Location.X - 1, Img6.Location.Y - 1);
        }

        private void Img7_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img7.Location.X - 1, Img7.Location.Y - 1);
        }

        private void Img8_MouseEnter(object sender, EventArgs e)
        {
            FundSelect.Visible = true;
            FundSelect.Location = new Point(Img8.Location.X - 1, Img8.Location.Y - 1);
        }

        private void Img1_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img2_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img3_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img4_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img5_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img6_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img7_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img8_MouseLeave(object sender, EventArgs e)
        {
            FundSelect.Visible = false;
        }

        private void Img1_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[0, 0];
            FundMarc.Location = new Point(Img1.Location.X - 1, Img1.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img2_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[1, 0];
            FundMarc.Location = new Point(Img2.Location.X - 1, Img2.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img3_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[2, 0];
            FundMarc.Location = new Point(Img3.Location.X - 1, Img3.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img4_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[3, 0];
            FundMarc.Location = new Point(Img4.Location.X - 1, Img4.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img5_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[4, 0];
            FundMarc.Location = new Point(Img5.Location.X - 1, Img5.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img6_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[5, 0];
            FundMarc.Location = new Point(Img6.Location.X - 1, Img6.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img7_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[6, 0];
            FundMarc.Location = new Point(Img7.Location.X - 1, Img7.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void Img8_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Text = candidatos[7, 0];
            FundMarc.Location = new Point(Img8.Location.X - 1, Img8.Location.Y - 1);
            FundMarc.Visible = true;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            LstMostrar.Items.Clear();
            for (int i = 0; i < 8; i++)
                LstMostrar.Items.Add(candidatos[i, 0] + ": " + candidatos[i, 1]);
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtCandidatos.Text == "")
                return;
            for (int i = 0; i < 8; i++)
                if (TxtCandidatos.Text == candidatos[i, 0])
                {
                    candidatos[i, 1] = "" + (Convert.ToInt32(candidatos[i, 1]) + 1);
                    break;
                }
            BtnMostrar.PerformClick();
            TxtCandidatos.Clear();
            som.Play();
            FundMarc.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCandidatos.Clear();
            FundMarc.Visible = false;
        }
    }
}