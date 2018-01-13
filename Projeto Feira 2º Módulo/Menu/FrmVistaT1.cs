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
    public partial class FrmVistaT1 : Form
    {
        public static int acertos = 0;
        string linha1, linha2, linha3, linha4, linha5;

        public FrmVistaT1()
        {
            InitializeComponent(); Random rdn = new Random();
            linha1 = "" + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26));
            linha2 = "" + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26));
            linha3 = "" + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26));
            linha4 = "" + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26));
            linha5 = "" + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26)) + Convert.ToChar(65 + rdn.Next(0, 26));
            LblLinha1.Text = linha1[0] + " " + linha1[1] + " " + linha1[2] + " " + linha1[3] + " " + linha1[4];
            LblLinha2.Text = linha2[0] + " " + linha2[1] + " " + linha2[2] + " " + linha2[3] + " " + linha2[4];
            LblLinha3.Text = linha3[0] + " " + linha3[1] + " " + linha3[2] + " " + linha3[3] + " " + linha3[4];
            LblLinha4.Text = linha4[0] + " " + linha4[1] + " " + linha4[2] + " " + linha4[3] + " " + linha4[4];
            LblLinha5.Text = linha5[0] + " " + linha5[1] + " " + linha5[2] + " " + linha5[3] + " " + linha5[4];
        }

        private void FrmVista_SizeChanged(object sender, EventArgs e)
        {
            LblTitulo.Location = new Point(this.Width / 2 - LblTitulo.Width / 2, LblTitulo.Height);
            TxtTextoUsu.Location = new Point(this.Width - TxtTextoUsu.Width - 12, this.Height / 2 - TxtTextoUsu.Height / 2);
            LblTexto.Location = new Point(TxtTextoUsu.Location.X, TxtTextoUsu.Location.Y - LblTexto.Height - 12);
            int dif21 = LblLinha2.Location.Y - LblLinha1.Location.Y;
            int dif32 = LblLinha3.Location.Y - LblLinha2.Location.Y;
            int dif43 = LblLinha4.Location.Y - LblLinha3.Location.Y;
            int dif54 = LblLinha5.Location.Y - LblLinha4.Location.Y;
            LblLinha1.Location = new Point(this.Width / 2 - LblLinha1.Width / 2 - TxtTextoUsu.Width / 2 - 12, this.Height / 2 - (LblLinha4.Location.Y - LblLinha1.Location.Y + LblLinha4.Height) / 2);
            LblLinha2.Location = new Point(LblLinha1.Location.X + LblLinha1.Width / 2 - LblLinha2.Width / 2, LblLinha1.Location.Y + dif21);
            LblLinha3.Location = new Point(LblLinha2.Location.X + LblLinha2.Width / 2 - LblLinha3.Width / 2, LblLinha2.Location.Y + dif32);
            LblLinha4.Location = new Point(LblLinha3.Location.X + LblLinha3.Width / 2 - LblLinha4.Width / 2, LblLinha3.Location.Y + dif43);
            LblLinha5.Location = new Point(LblLinha4.Location.X + LblLinha4.Width / 2 - LblLinha5.Width / 2, LblLinha4.Location.Y + dif54);
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);

        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            TimAtualizarTempo.Stop();
            FrmMenu.FrmMain.TimTempoCountStatus(false);
            if (TxtTextoUsu.Text == (linha1 + "\n" + linha2 + "\n" + linha3 + "\n" + linha4 + "\n" + linha5).ToUpper())
            {
                acertos++;
                MessageBox.Show("Você acertou.");
            }
            else
                MessageBox.Show("Você errou.");
            FrmVistaT2 inst = new FrmVistaT2();
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

        private void TxtTextoUsu_TextChanged(object sender, EventArgs e)
        {
            TxtTextoUsu.Text = TxtTextoUsu.Text.ToUpper();
            TxtTextoUsu.Select(TxtTextoUsu.Text.Length, TxtTextoUsu.Text.Length);
        }

        private void FrmVistaT1_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo.Start();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void FrmVistaT1_FormClosing(object sender, FormClosingEventArgs e)
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
