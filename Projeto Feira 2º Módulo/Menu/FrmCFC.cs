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
    public partial class FrmCFC : Form
    {
        string[,] perg = new string[15, 7];
        int perguntaAtual = 0;
        public static int acertos = 0;

        public FrmCFC()
        {
            perg[0, 0] = "1. A-5B Este sinal indica:";
            perg[0, 1] = "Curva à esquerda.";
            perg[0, 2] = "Curva em \"S\" à Direita.";
            perg[0, 3] = "Desvio à esquerda.";
            perg[0, 4] = "Obras à direita.";
            perg[0, 5] = "NDA.";
            perg[0, 6] = "b";

            perg[1, 0] = "2. A-10A Este sinal indica:";
            perg[1, 1] = "Bifurcação em Y.";
            perg[1, 2] = "Retorno à esquerda.";
            perg[1, 3] = "Entroncamento oblíquo à esquerda.";
            perg[1, 4] = "Confluência à esquerda.";
            perg[1, 5] = "NDA.";
            perg[1, 6] = "d";

            perg[2, 0] = "3. A-13B Este sinal indica:";
            perg[2, 1] = "Entroncamento oblíquo à esquerda.";
            perg[2, 2] = "Entroncamento oblíquo á direita.";
            perg[2, 3] = "Junção à esquerda.";
            perg[2, 4] = "Confluência à Direita.";
            perg[2, 5] = "NDA.";
            perg[2, 6] = "d";

            perg[3, 0] = "4. A-14 Este sinal indica:";
            perg[3, 1] = "Semáforo trifásico.";
            perg[3, 2] = "Semáforo à frente.";
            perg[3, 3] = "Passagem de sinalização de pedestre e veículos.";
            perg[3, 4] = "Cruzamento à frente.";
            perg[3, 5] = "NDA.";
            perg[3, 6] = "b";

            perg[4, 0] = "5. A-42A Este sinal indica:";
            perg[4, 1] = "Inicio de pista dupla.";
            perg[4, 2] = "Fim de pista dupla.";
            perg[4, 3] = "Obras ao centro da pista.";
            perg[4, 4] = "Pista dividida.";
            perg[4, 5] = "NDA.";
            perg[4, 6] = "a";

            perg[5, 0] = "6. A-42B Este sinal indica:";
            perg[5, 1] = "Início de pista dupla.";
            perg[5, 2] = "Fim de pista dupla.";
            perg[5, 3] = "Obras ao centro da pista.";
            perg[5, 4] = "Pista dividida.";
            perg[5, 5] = "NDA.";
            perg[5, 6] = "b";

            perg[6, 0] = "7. A-3B Este sinal indica:";
            perg[6, 1] = "Pista escorregadia.";
            perg[6, 2] = "Pista sinuosa à esquerda.";
            perg[6, 3] = "Curva em \"S\" à esquerda.";
            perg[6, 4] = "Curvas em \"S\" sucessivas e contrárias, primeira à esquerda.";
            perg[6, 5] = "NDA.";
            perg[6, 6] = "b";

            perg[7, 0] = "8. I-15 Este sinal indica:";
            perg[7, 1] = "Emergência.";
            perg[7, 2] = "Cruz Vermelha.";
            perg[7, 3] = "Oficina.";
            perg[7, 4] = "Pronto Socorro.";
            perg[7, 5] = "NDA.";
            perg[7, 6] = "d";

            perg[8, 0] = "9. R-2 Este sinal indica:";
            perg[8, 1] = "Cruze com cuidado.";
            perg[8, 2] = "Semáforo a frente.";
            perg[8, 3] = "Dê a preferência.";
            perg[8, 4] = "Bifurcação.";
            perg[8, 5] = "NDA.";
            perg[8, 6] = "c";

            perg[9, 0] = "10. R-4B este sinal indica:";
            perg[9, 1] = "Proibido virar à direita.";
            perg[9, 2] = "Vire a esquerda.";
            perg[9, 3] = "Retorno à direita.";
            perg[9, 4] = "Desvio à direita.";
            perg[9, 5] = "NDA.";
            perg[9, 6] = "a";

            perg[10, 0] = "11. R-11 Este sinal indica:";
            perg[10, 1] = "Proibido animais soltos.";
            perg[10, 2] = "Proibido trânsito de veículos de tração animal.";
            perg[10, 3] = "Permitido tráfego de veículos de tração animal.";
            perg[10, 4] = "As alternativas acima estão todas corretas.";
            perg[10, 5] = "NDA.";
            perg[10, 6] = "b";

            perg[11, 0] = "12. Qual a velocidade máxima nas vias locais, onde não existir sinalização regulamentadora?";
            perg[11, 1] = "30Km/h.";
            perg[11, 2] = "60Km/h.";
            perg[11, 3] = "80Km/h.";
            perg[11, 4] = "100Km/h.";
            perg[11, 5] = "NDA.";
            perg[11, 6] = "a";

            perg[12, 0] = "13. Dirigir veículo com a validade da Carteira Nacional de Habilitação vencida a mais de trinta dias, é considerado infração?";
            perg[12, 1] = "Média.";
            perg[12, 2] = "Grave.";
            perg[12, 3] = "Gravíssima.";
            perg[12, 4] = "Não é considerado infração.";
            perg[12, 5] = "NDA.";
            perg[12, 6] = "c";

            perg[13, 0] = "14. Movimento em ângulo à esquerda ou à direita, de mudança de direção original do veículo, chamamos de?";
            perg[13, 1] = "Infração Média.";
            perg[13, 2] = "Infração Grave.";
            perg[13, 3] = "Curva acentuada à esquerda ou à direita.";
            perg[13, 4] = "Conversão.";
            perg[13, 5] = "NDA.";
            perg[13, 6] = "d";

            perg[14, 0] = "15. O que é um Cruzamento?:";
            perg[14, 1] = "Interseção de suas vias em nível.";
            perg[14, 2] = "Interseção de um número variável de vias.";
            perg[14, 3] = "União de duas vias perpendiculares.";
            perg[14, 4] = "Interseção de vias arterial com via local.";
            perg[14, 5] = "NDA.";
            perg[14, 6] = "a";

            InitializeComponent();

            LblPergunta.Text = perg[0, 0];
            Rdb1.Text = perg[0, 1];
            Rdb2.Text = perg[0, 2];
            Rdb3.Text = perg[0, 3];
            Rdb4.Text = perg[0, 4];
            Rdb5.Text = perg[0, 5];
            VerificarImagem();
        }

        private void FrmCFC_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FrmCFC_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            LblFaltaPerguntas.Location = new Point(this.Width / 2 - LblFaltaPerguntas.Width / 2, 12);
            ImgPlaca.Location = new Point(this.Width - ImgPlaca.Width - 12, this.Height / 2 - ImgPlaca.Height / 2);
        }

        private void FrmCFC_Load(object sender, EventArgs e)
        {
            TimAtualizarTempo.Start();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza de que deseja desistir de tirar carta de motorista?", "Atensão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FrmMenu.FrmMain.PararTeste();
                FrmMenu.FrmMain.Show();
                Dispose();
            }
        }

        private void VerificarImagem()
        {
            switch (perguntaAtual)
            {
                case 0:
                    ImgPlaca.Image = Resources.A_5B;
                    break;
                case 1:
                    ImgPlaca.Image = Resources.A_10A;
                    break;
                case 2:
                    ImgPlaca.Image = Resources.A_13B;
                    break;
                case 3:
                    ImgPlaca.Image = Resources.A_14;
                    break;
                case 4:
                    ImgPlaca.Image = Resources.A_42A;
                    break;
                case 5:
                    ImgPlaca.Image = Resources.A_42B;
                    break;
                case 6:
                    ImgPlaca.Image = Resources.A_3B;
                    break;
                case 7:
                    ImgPlaca.Image = Resources.I15;
                    break;
                case 8:
                    ImgPlaca.Image = Resources.R_2;
                    break;
                case 9:
                    ImgPlaca.Image = Resources.R_4B;
                    break;
                case 10:
                    ImgPlaca.Image = Resources.R_11;
                    break;
                default:
                    ImgPlaca.Image = null;
                    ImgPlaca.Visible = false;
                    break;
            }
            FrmCFC_SizeChanged(null, null);
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            string marcada = "";
            if (Rdb1.Checked)
                marcada = "a";
            if (Rdb2.Checked)
                marcada = "b";
            if (Rdb3.Checked)
                marcada = "c";
            if (Rdb4.Checked)
                marcada = "d";
            if (Rdb5.Checked)
                marcada = "e";
            if (marcada == perg[perguntaAtual, 6])
                acertos++;
            perguntaAtual++;
            if (perguntaAtual >= 15)
            {
                FrmMenu.FrmMain.TimTempoCountStatus(false);
                FrmCFCFim inst = new FrmCFCFim();
                inst.Show();
                Dispose();
                return;
            }
            VerificarImagem();
            LblFaltaPerguntas.Text = String.Format("Pergunta {0:00}/15", (perguntaAtual + 1));
            LblPergunta.Text = perg[perguntaAtual, 0];
            Rdb1.Text = perg[perguntaAtual, 1];
            Rdb2.Text = perg[perguntaAtual, 2];
            Rdb3.Text = perg[perguntaAtual, 3];
            Rdb4.Text = perg[perguntaAtual, 4];
            Rdb5.Text = perg[perguntaAtual, 5];
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