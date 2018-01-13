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
    public partial class FrmPsicT3 : Form
    {
        int status = 0, acertos = 0, contagem = 15;

        public FrmPsicT3()
        {
            InitializeComponent();
            LblLocalTempo.Text = string.Format("{0:00} seg", contagem);
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void troca1()
        {
            TimLocalTempo.Stop();
            if (contagem < 10)
                contagem = 10;
            LblLocalTempo.Text = string.Format("{0:00} seg", contagem);

            LblPalavra.Text = "Vermelho";
            LblPalavra.ForeColor = Color.Lime;

            Lbl1.Text = "Azul";
            Lbl1.ForeColor = Color.Red;

            Lbl2.Text = "Preto";
            Lbl2.ForeColor = Color.White;
            Lbl2.BackColor = Color.Black;

            Lbl3.Text = "Branco";
            Lbl3.ForeColor = Color.Blue;

            Lbl4.Text = "Verde";
            Lbl4.ForeColor = Color.White;
            Lbl4.BackColor = Color.Black;

            Lbl5.Text = "Amarelo";
            Lbl5.ForeColor = Color.Yellow;
            Lbl5.BackColor = Color.Black;

            Lbl6.Text = "Vermelho";
            Lbl6.ForeColor = Color.Red;

            FrmPsicT3_SizeChanged(null, null);
            TimLocalTempo.Start();
            status++;
        }

        private void troca2()
        {
            TimLocalTempo.Stop();
            if (contagem < 10)
                contagem = 10;
            LblLocalTempo.Text = string.Format("{0:00} seg", contagem);

            LblPalavra.Text = "Preto";
            LblPalavra.ForeColor = Color.White;
            LblPalavra.BackColor = Color.Black;

            Lbl1.Text = "Amarelo";
            Lbl1.ForeColor = Color.Black;
            Lbl4.BackColor = Color.White;

            Lbl2.Text = "Preto";
            Lbl2.ForeColor = Color.White;
            Lbl2.BackColor = Color.Black;

            Lbl3.Text = "Vermelho";
            Lbl3.ForeColor = Color.Blue;
            Lbl3.BackColor = Color.Yellow;

            Lbl4.Text = "Branco";
            Lbl4.ForeColor = Color.Red;
            Lbl4.BackColor = Color.Lime;

            Lbl5.Text = "Azul";
            Lbl5.ForeColor = Color.Lime;
            Lbl5.BackColor = Color.Black;

            Lbl6.Text = "Verde";
            Lbl6.ForeColor = Color.Yellow;
            Lbl6.BackColor = Color.Red;

            FrmPsicT3_SizeChanged(null, null);
            TimLocalTempo.Start();
            status++;
        }

        private void TerminarTeste()
        {
            if (acertos > 1)
                FrmPsicT1.acertos++;
            BtnProx.PerformClick();
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                troca1();
                acertos++;
            }
            else if (status == 1)
                troca2();
            else
                TerminarTeste();
        }

        private void Lbl4_Click(object sender, EventArgs e)
        {
            if (status == 0)
                troca1();
            if (status == 1)
            {
                troca2();
                acertos++;
            }
            else
            {
                acertos++;
                TerminarTeste();
            }
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
            if (status == 0)
                troca1();
            else if (status == 1)
                troca2();
            else
                TerminarTeste();
        }

        private void Lbl2_Click(object sender, EventArgs e)
        {
            if (status == 0)
                troca1();
            else if (status == 1)
                troca2();
            else
                TerminarTeste();
        }

        private void Lbl5_Click(object sender, EventArgs e)
        {
            if (status == 0)
                troca1();
            else if (status == 1)
                troca2();
            else
                TerminarTeste();
        }

        private void Lbl6_Click(object sender, EventArgs e)
        {
            if (status == 0)
                troca1();
            else if (status == 1)
                troca2();
            else
                TerminarTeste();
        }

        private void FrmPsicT3_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            Lbl2.Location = new Point(this.Width / 2 - Lbl2.Width / 2 - 200, this.Height / 2 - Lbl2.Height / 2);
            Lbl5.Location = new Point(this.Width / 2 - Lbl5.Width / 2 + 200, this.Height / 2 - Lbl2.Height / 2);
            Lbl1.Location = new Point(this.Width / 2 - Lbl1.Width / 2 - 200, this.Height / 2 - Lbl2.Height / 2 - 100);
            Lbl4.Location = new Point(this.Width / 2 - Lbl4.Width / 2 + 200, this.Height / 2 - Lbl2.Height / 2 - 100);
            Lbl3.Location = new Point(this.Width / 2 - Lbl3.Width / 2 - 200, this.Height / 2 - Lbl2.Height / 2 + 100);
            Lbl6.Location = new Point(this.Width / 2 - Lbl6.Width / 2 + 200, this.Height / 2 - Lbl2.Height / 2 + 100);
            LblPalavra.Location = new Point(this.Width / 2 - LblPalavra.Width / 2, this.Height / 2 - LblPalavra.Height / 2 - 200);
            LblInfo.Location = new Point(this.Width / 2 - LblInfo.Width / 2, LblPalavra.Location.Y / 2 - LblInfo.Height / 2);
            LblLocalTempo.Location = new Point(this.Width / 2 - LblLocalTempo.Width / 2, LblPalavra.Location.Y - LblLocalTempo.Height);
        }

        private void FrmPsicT3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
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

        private void TimAtualizarTempo_Tick(object sender, EventArgs e)
        {
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
            if (FrmMenu.tempoCount <= 0)
            {
                FrmMenu.FrmMain.Show();
                Dispose();
            }
        }

        private void TimLocalTempo_Tick(object sender, EventArgs e)
        {
            contagem--;
            if (contagem == 0)
                BtnProx.PerformClick();
            LblLocalTempo.Text = string.Format("{0:00} seg", contagem);
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            FrmPsicT4 inst = new FrmPsicT4();
            inst.Show();
            Dispose();
        }
    }
}