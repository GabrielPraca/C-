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
    public partial class FrmPergunta2 : Form
    {
        int contagem = 9;

        public FrmPergunta2()
        {
            InitializeComponent();
        }

        private void BtnReponder_Click(object sender, EventArgs e)
        {
            if (RdbResp4.Checked)
                FrmLoadScreen.acertos++;
            else
                FrmLoadScreen.erros++;
            FrmPergunta3 insForm = new FrmPergunta3();
            insForm.Show();
            Tempo.Stop();
            this.Dispose();
        }

        private void FrmPergunta2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmPergunta2_Load(object sender, EventArgs e)
        {
            Tempo.Start();
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
