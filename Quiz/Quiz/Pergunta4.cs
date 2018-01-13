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
    public partial class FrmPergunta4 : Form
    {
        int contagem = 9;

        public FrmPergunta4()
        {
            InitializeComponent();
        }

        private void FrmPergunta4_Load(object sender, EventArgs e)
        {
            Tempo.Start();
        }

        private void FrmPergunta4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnReponder_Click(object sender, EventArgs e)
        {
            if (RdbResp1.Checked)
                FrmLoadScreen.acertos++;
            else
                FrmLoadScreen.erros++;
            FrmPergunta5 insForm = new FrmPergunta5();
            insForm.Show();
            Tempo.Stop();
            this.Dispose();
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
    }
}
