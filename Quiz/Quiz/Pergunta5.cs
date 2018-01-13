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
    public partial class FrmPergunta5 : Form
    {
        int contagem = 9;

        public FrmPergunta5()
        {
            InitializeComponent();
        }

        private void Pergunta5_Load(object sender, EventArgs e)
        {
            Tempo.Start();
            RdbResp3.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Pergunta5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tempo_Tick(object sender, EventArgs e)
        {
            RdbResp3.Text = DateTime.Now.ToString("HH:mm");
            LblContagem.Text = "" + contagem;
            if (contagem == 0)
            {
                Tempo.Stop();
                MessageBox.Show("Seu tempo acabou!", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            contagem--;
        }

        private void BtnReponder_Click(object sender, EventArgs e)
        {
            if (RdbResp3.Checked)
                FrmLoadScreen.acertos++;
            else
                FrmLoadScreen.erros++;
            FrmFim insForm = new FrmFim();
            insForm.Show();
            Tempo.Stop();
            this.Dispose();
        }
    }
}
