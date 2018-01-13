using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vetor
{
    public partial class FrmVetor : Form
    {
        string[] nome = new string[3];//vetor global

        public FrmVetor()
        {
            InitializeComponent();
        }

        private void BtnMostra_Click(object sender, EventArgs e)
        {
            LstMostrar.Items.Clear();
            CbMostrar.Items.Clear();
            for (int i = 0; i < nome.Length; i++)
                if (nome[i] != null)
                {
                    LstMostrar.Items.Add(nome[i]);
                    CbMostrar.Items.Add(nome[i]);
                }
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nome.Length; i++)
                if (nome[i] == null)
                {
                    if (TxtNome.Text == "")
                    {
                        MessageBox.Show("Digite um nome.");
                        return;
                    }
                    nome[i] = TxtNome.Text;
                    TxtNome.Clear();
                    TxtNome.Focus();
                    if (i != nome.Length - 1)
                        return;
                    else
                    {
                        Array.Sort(nome); //Ordem Crescente
                        //Array.Reverse(nome); //Decrescente
                        TimAnim.Start();
                        BtnMostra.Focus();
                        return;
                    }
                }
        }

        private void TimAnim_Tick(object sender, EventArgs e)
        {
            if (TxtNome.Location.X + TxtNome.Width > 0)
            {
                TxtNome.Location = new Point(TxtNome.Location.X - 1, TxtNome.Location.Y);
                BtnCarregar.Location = new Point(BtnCarregar.Location.X - 1, BtnCarregar.Location.Y);
            }
            else if (BtnMostra.Location.Y + BtnMostra.Height / 2 > this.Height / 2 - 34 / 2)
                BtnMostra.Location = new Point(BtnMostra.Location.X, BtnMostra.Location.Y - 1);
            else
                TimAnim.Stop();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                BtnCarregar.PerformClick();
        }
    }
}
