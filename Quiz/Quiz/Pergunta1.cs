using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmPergunta1 : Form
    {
        int contagem = 9;

        public FrmPergunta1()
        {
            InitializeComponent();
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            LblContagem.Text = "" + contagem;
            if (contagem == 0)
            {
                Tempo.Stop();
                MessageBox.Show("Seu tempo acabou!", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            contagem--;
        }

        private void FrmPergunta1_Load(object sender, EventArgs e)
        {
            Tempo.Start();
        }

        private void BtnReponder_Click(object sender, EventArgs e)
        {
            if (RdbResp2.Checked)
                FrmLoadScreen.acertos++;
            else
                FrmLoadScreen.erros++;
            Tempo.Stop();
            FrmPergunta2 insForm = new FrmPergunta2();
            Close();
            insForm.Show();
        }

        private void FrmPergunta1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
