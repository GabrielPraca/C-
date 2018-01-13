using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Joquempo_Multiplayer.Properties;

namespace Joquempo_Multiplayer
{
    public partial class FrmJP : Form
    {
        public enum JPTipo
        {
            Pedra,
            Papel,
            Tesoura
        }

        FrmMain formMain;
        JPTipo[] TipoGanha = { JPTipo.Tesoura, JPTipo.Pedra, JPTipo.Papel };
        public int MeuNumJogador;
        bool BtnsAtivos = false;
        System.Media.SoundPlayer Som = new System.Media.SoundPlayer(Resources.tapa);

        byte Pontos1 = 0,
             Pontos2 = 0;

        JPTipo Img1 = JPTipo.Pedra,
               Img2 = JPTipo.Papel;

        JPTipo? Escolha1 = null,
                Escolha2 = null;

        public FrmJP(FrmMain Form)
        {
            InitializeComponent();
            formMain = Form;
        }

        public void autenticarJogador(int NumJogador, string Nome)
        {
            switch (NumJogador)
            {
                case 1:
                    int DistanciaD = LblNome1.Left + LblNome1.Width;
                    LblNome1.Text = Nome;
                    LblNome1.Left = DistanciaD - LblNome1.Width;
                    break;
                case 2:
                    LblNome2.Text = Nome;
                    break;
            }
            if (LblNome1.Text != "Aguardando jogador..." && LblNome2.Text != "Aguardando jogador...")
            {
                LblEspera1.Visible = LblEspera2.Visible = true;
                Pic1.Visible = Pic2.Visible = true;
                BtnsAtivos = true;
            }
        }

        public void jogadorDesconectou(int NumJogador)
        {
            switch (NumJogador)
            {
                case 1:
                    formMain.Visible = true;
                    Close();
                    break;
                case 2:
                    LblEspera1.Visible = LblEspera2.Visible = false;
                    Pic1.Visible = Pic2.Visible = false;
                    Escolha1 = Escolha2 = null;
                    Pontos1 = Pontos2 = 0;
                    BtnsAtivos = true;
                    LblNome2.Text = "Aguardando jogador...";
                    MessageBox.Show("O outro jogador saiu.");
                    break;
            }
        }

        private void Botao_MouseEnter(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            Btn.Left -= 1;
            Btn.Top -= 1;
        }

        private void Botao_MouseLeave(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            Btn.Left += 1;
            Btn.Top += 1;
        }

        private Image getImagemPeloJPTipo(JPTipo Tipo)
        {
            switch (Tipo)
            {
                case JPTipo.Pedra:
                    return Resources.Pedra;
                case JPTipo.Papel:
                    return Resources.Papel;
                case JPTipo.Tesoura:
                    return Resources.Tesoura;
                default:
                    return null;
            }
        }

        private void TimTrocaImg_Tick(object sender, EventArgs e)
        {
            Img1 = (JPTipo)((int)++Img1 % 3);
            Img2 = (JPTipo)((int)++Img2 % 3);

            if (Escolha1 == null || (Escolha2 == null && Escolha1 != null && MeuNumJogador == 2))
                Pic1.Image = getImagemPeloJPTipo(Img1);
            if (Escolha2 == null || (Escolha1 == null && Escolha2 != null && MeuNumJogador == 1))
                Pic2.Image = getImagemPeloJPTipo(Img2);
        }

        public void setJogada(int NumJogador, JPTipo Jogada)
        {
            switch (NumJogador)
            {
                case 1:
                    Escolha1 = Jogada;
                    LblEspera1.Visible = false;
                    if (MeuNumJogador == 1)
                        Pic1.Image = getImagemPeloJPTipo((JPTipo)Escolha1);
                    break;
                case 2:
                    Escolha2 = Jogada;
                    LblEspera2.Visible = false;
                    if (MeuNumJogador == 2)
                        Pic2.Image = getImagemPeloJPTipo((JPTipo)Escolha2);
                    break;
            }

            if (Escolha1 != null && Escolha2 != null)
            {
                Som.Play();
                Pic1.Image = getImagemPeloJPTipo((JPTipo)Escolha1);
                Pic2.Image = getImagemPeloJPTipo((JPTipo)Escolha2);

                int ganhou = 0;

                if (Escolha1 != Escolha2)
                {
                    if (Escolha2 == TipoGanha[(int)Escolha1])
                        ganhou = 1;
                    else
                        ganhou = 2;
                }

                if (ganhou == 0)
                    LblGanhador.Text = "Empate";
                else if (ganhou == 1)
                {
                    LblGanhador.Text = LblNome1.Text + " ganhou";
                    Pontos1++;
                    LblVitorias1.Text = "Vitórias: " + Pontos1;
                }
                else if (ganhou == 2)
                {
                    LblGanhador.Text = LblNome2.Text + " ganhou";
                    Pontos2++;
                    LblVitorias2.Text = "Vitórias: " + Pontos2;
                }

                LblGanhador.Left = Width / 2 - LblGanhador.Width / 2;
                LblGanhador.Visible = true;
                BtnsAtivos = false;
                TimResetaJogada.Start();
            }
        }

        private void BtnPedra_Click(object sender, EventArgs e)
        {
            if (!BtnsAtivos)
                return;
            setJogada(MeuNumJogador, JPTipo.Pedra);
            formMain.EnviaJogada(MeuNumJogador, JPTipo.Pedra);
        }

        private void BtnPapel_Click(object sender, EventArgs e)
        {
            if (!BtnsAtivos)
                return;
            setJogada(MeuNumJogador, JPTipo.Papel);
            formMain.EnviaJogada(MeuNumJogador, JPTipo.Papel);
        }

        private void BtnTesoura_Click(object sender, EventArgs e)
        {
            if (!BtnsAtivos)
                return;
            setJogada(MeuNumJogador, JPTipo.Tesoura);
            formMain.EnviaJogada(MeuNumJogador, JPTipo.Tesoura);
        }

        private void FrmJP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MeuNumJogador == 1)
                formMain.desligarServidor();
            else
                formMain.desligarCliente();
        }

        private void TimResetaJogada_Tick(object sender, EventArgs e)
        {
            TimResetaJogada.Stop();
            if (Pontos1 >= 5 || Pontos2 >= 5)
            {
                string Nome;
                if (Pontos1 > Pontos2)
                    Nome = LblNome1.Text;
                else
                    Nome = LblNome2.Text;
                MessageBox.Show(string.Format("Fim de jogo, {0} ganhou. Placar:\n{1}: {2}\n{3}: {4}", Nome, LblNome2.Text, Pontos2, LblNome1.Text, Pontos1));

                Close();
            }
            Escolha1 = Escolha2 = null;
            LblEspera1.Visible = LblEspera2.Visible = true;
            LblGanhador.Visible = false;
            BtnsAtivos = true;
        }
    }
}
