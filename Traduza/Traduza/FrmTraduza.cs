using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Traduza.Properties;

namespace Traduza
{
    public partial class FrmTraduza : Form
    {
        int Pontos1 = 0, Pontos2 = 0;
        byte statusAnim = 0,
             vez = 1;
        bool cli1, cli2;
        int[] usados = {};
        int mostrando = 0;
        string[] palavraIng = {"Form",
                               "Display",
                               "Canvas",
                               "Asphalt",
                               "Clock",
                               "Sky",
                               "Cabinet",
                               "Tram",
                               "Bundle",
                               "Share",
                               "Word",
                               "Beach",
                               "Stop",
                               "Book"};

        string[] palavraPTBR = {"Formulário",
                                "Visor",
                                "Tela",
                                "Asfalto",
                                "Relógio",
                                "Céu",
                                "Armário",
                                "Bonde",
                                "Trouxa",
                                "Compartilhar",
                                "Palavra",
                                "Praia",
                                "Parar",
                                "Livro"};

        string[] significado = {"documento pré-impresso onde são preenchidos os dados e informações.",
                                "é um dispositivo para a apresentação de informação.",
                                "é uma superfície esticada usada para exibir imagem.",
                                "é um betume espesso, de material aglutinante escuro e reluzente.",
                                "Maquinismo que serve para marcar o tempo e indicar as horas.",
                                "Espaço infinito no qual se movem os astros.Parte do espaço que parece formar uma abóbada em cima.",
                                "Móvel em forma de caixa alta, com prateleiras, que serve para guardar roupas, louças, papéis etc.",
                                "Veículo urbano, de tração elétrica, que circula sobre trilhos e se destina ao transporte coletivo de passageiros e/ou de cargas.",
                                "Embrulho que contém roupa.",
                                "Compartir.",
                                "Conjunto de letras.",
                                "Local para se banhar.",
                                "Terminar execução",
                                "Publicação encadernada e não periódica."};

        string[] emFrase = {"para se cadastrar, basta preencher o ...",
                            "Aquele ... Estava quebrado.",
                            "Aquela ... é exageradamente grande.",
                            "Todas as estradas por onde andei tinham ...",
                            "A culpa do meu atraso é do meu ...",
                            "As nuvens passam pelo ...",
                            "Peguei um copo no ...",
                            "Vou embarcar no ...",
                            "Lave toda essa ...",
                            "Vou ... alguns arquivos do meu computador.",
                            "Uma imagem vale mais que mil ...",
                            "Eu vou à ...",
                            "... agora",
                            "Rasgou o ..."};

        public FrmTraduza()
        {
            InitializeComponent();
            AtualizarPalavra();
            LblEmFrase.Width = 0;
            LblSig.Width = 0;
            AjutarCorNomes();
            LblJogador1.Text = FrmMain.nome1;
            LblJogador2.Text = FrmMain.nome2;
            LblJogador1.Location = new Point(LblPontos1.Location.X + LblPontos1.Width / 2 - LblJogador1.Width / 2, LblJogador1.Location.Y);
            LblJogador2.Location = new Point(LblPontos2.Location.X + LblPontos2.Width / 2 - LblJogador2.Width / 2, LblJogador2.Location.Y);
        }

        private void AtualizarPalavra()
        {
            Random rdm = new Random();
            int verificar = rdm.Next(palavraIng.Length);
            while (true)
            {
                if (palavraIng.Length == usados.Length)
                    return;
                bool encontrado = false;
                for (int i = 0; i < usados.Length; i++)
                    if (verificar == usados[i])
                        encontrado = true;
                if (!encontrado)
                {
                    Array.Resize(ref usados, usados.Length + 1);
                    usados[usados.Length - 1] = verificar;
                    break;
                }
                else
                    verificar = rdm.Next(palavraIng.Length);

            }
            LblSig.Text = "Significado:";
            LblEmFrase.Text = "Aplicação em uma frase:";
            mostrando = verificar;
            cli1 = cli2 = false;
            LblPalavraIng.Text = palavraIng[verificar].ToUpper();
            LblPalavraIng.Location = new Point(this.Width / 2 - LblPalavraIng.Width / 2, LblPalavraIng.Location.Y);
        }

        private void AjutarCorNomes()
        {
            if (vez == 1)
            {
                LblJogador1.ForeColor = Color.White;
                LblPontos1.ForeColor = Color.White;
                LblJogador2.ForeColor = Color.Silver;
                LblPontos2.ForeColor = Color.Silver;
            }
            else
            {
                LblJogador2.ForeColor = Color.White;
                LblPontos2.ForeColor = Color.White;
                LblJogador1.ForeColor = Color.Silver;
                LblPontos1.ForeColor = Color.Silver;
            }
        }

        private void FrmTraduza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TimAnim_Tick(object sender, EventArgs e)
        {
            switch (statusAnim)
            {
                case 0:
                    if (this.Opacity < 1)
                        this.Opacity += 0.1;
                    else
                        statusAnim = 1;
                    break;
                case 1:
                    if (LblEmFrase.Width < LblEmFrase.PreferredWidth)
                    {
                        LblEmFrase.Width += 4;
                        if (LblEmFrase.Width > LblEmFrase.PreferredWidth)
                            LblEmFrase.Width = LblEmFrase.PreferredWidth;
                    }
                    else if (LblEmFrase.Width > LblEmFrase.PreferredWidth)
                    {
                        LblEmFrase.Width -= 4;
                        if (LblEmFrase.Width < LblEmFrase.PreferredWidth)
                            LblEmFrase.Width = LblEmFrase.PreferredWidth;
                    }
                    if (LblSig.Width < LblSig.PreferredWidth)
                    {
                        LblSig.Width += 4;
                        if (LblSig.Width > LblSig.PreferredWidth)
                            LblSig.Width = LblSig.PreferredWidth;
                    }
                    if (LblSig.Width > LblSig.PreferredWidth)
                    {
                        LblSig.Width -= 4;
                        if (LblSig.Width < LblSig.PreferredWidth)
                            LblSig.Width = LblSig.PreferredWidth;
                    }
                    break;
                case 2:
                    LblPalavraIng.Text = DiminuirString(LblPalavraIng.Text, 1);
                    LblPalavraIng.Location = new Point(this.Width / 2 - LblPalavraIng.Width / 2, LblPalavraIng.Location.Y);
                    if (LblPalavraIng.Text == "")
                    {
                        if (TxtTryPTBR.Text.ToLower() == palavraPTBR[mostrando].ToLower())
                        {
                            LblPalavraIng.ForeColor = Color.Lime;
                            if (vez == 1)
                                Pontos1++;
                            else
                                Pontos2++;
                            LblPontos1.Text = "" + Pontos1;
                            LblPontos2.Text = "" + Pontos2; 
                        }
                        else
                            LblPalavraIng.ForeColor = Color.Red;
                        statusAnim = 3;
                    }
                    break;
                case 3:
                    string novaStr = LblPalavraIng.Text;
                    string finalStr = palavraPTBR[mostrando];
                    if (novaStr.Length < finalStr.Length)
                        LblPalavraIng.Text += finalStr[novaStr.Length];
                    else
                    {
                        TimAnim.Interval = 3000;
                        statusAnim = 4;
                    }
                    LblPalavraIng.Location = new Point(this.Width / 2 - LblPalavraIng.Width / 2, LblPalavraIng.Location.Y);
                    break;
                case 4:
                    statusAnim = 1;
                    string palavaAnt = LblPalavraIng.Text;
                    AtualizarPalavra();
                    TimAnim.Interval = 10;
                    if (palavaAnt == LblPalavraIng.Text)
                    {
                        statusAnim = 5;
                        return;
                    }
                    LblPalavraIng.ForeColor = Color.Black;
                    if (vez == 1)
                        vez++;
                    else
                        vez--;
                    AjutarCorNomes();
                    TxtTryPTBR.Clear();
                    TxtTryPTBR.Enabled = true;
                    TxtTryPTBR.Focus();
                    break;
                case 5:
                    if (this.Opacity > 0)
                        this.Opacity -= 0.1;
                    else
                    {
                        FrmFim inst = new FrmFim();
                        string ganhador;
                        if (Pontos1 > Pontos2)
                            ganhador = FrmMain.nome1;
                        else
                            ganhador = FrmMain.nome2;
                        inst.RecebeGanhador(ganhador);
                        inst.Show();
                        Dispose();
                    }
                    break;
            }
        }

        private string DiminuirString(string str, int quantidade)
        {
            string retorno = "";
            if (quantidade <= 0)
                return str;
            for (int i = 0; i < str.Length - quantidade; i++)
                retorno += str[i];
            return retorno;
        }

        private void LblSig_MouseEnter(object sender, EventArgs e)
        {
            LblSig.BackColor = Color.Teal;
        }

        private void LblEmFrase_MouseEnter(object sender, EventArgs e)
        {
            LblEmFrase.BackColor = Color.Teal;
        }

        private void LblSig_MouseLeave(object sender, EventArgs e)
        {
            LblSig.BackColor = Color.Transparent;
        }

        private void LblEmFrase_MouseLeave(object sender, EventArgs e)
        {
            LblEmFrase.BackColor = Color.Transparent;
        }

        private void LblSig_Click(object sender, EventArgs e)
        {
            if (!cli1)
            {
                cli1 = true;
                LblSig.Text += " " + significado[mostrando];
            }
            else
            {
                cli1 = false;
                LblSig.Text = "Significado:";
            }
        }

        private void LblEmFrase_Click(object sender, EventArgs e)
        {
            if (!cli2)
            {
                cli2 = true;
                LblEmFrase.Text += " " + emFrase[mostrando];
            }
            else
            {
                cli2 = false;
                LblEmFrase.Text = "Aplicação em uma frase:";
            }
        }

        private void TxtTryPTBR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
                e.Handled = true;
        }

        private void TxtTryPTBR_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtTryPTBR.Enabled)
            {
                TxtTryPTBR.Text = TxtTryPTBR.Text.Trim();
                if (TxtTryPTBR.Text == "")
                {
                    TxtTryPTBR.BackColor = Color.FromArgb(255, 200, 200);
                    return;
                }
                TxtTryPTBR.Enabled = false;
                TimAnim.Interval = 250;
                statusAnim = 2;
            }
        }

        private void TxtTryPTBR_TextChanged(object sender, EventArgs e)
        {
            if(TxtTryPTBR.Text != "")
                TxtTryPTBR.BackColor = Color.White;
        }
    }
}
