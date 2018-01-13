using System;
using System.Windows.Forms;
using System.Net.NetTCP;

namespace Joquempo_Multiplayer
{
    public partial class FrmMain : Form
    {
        ServidorTCP servidor = new ServidorTCP(1);
        ClienteTCP cliente = new ClienteTCP();
        FrmJP Jogo;

        public FrmMain()
        {
            InitializeComponent();

            servidor.servidorLigou += new ServidorTCP.EventoV(servidor_servidorLigou);
            servidor.servidorFalhou += new ServidorTCP.EventoV(servidor_servidorFalhou);
            servidor.servidorDesligou += new ServidorTCP.EventoV(servidor_servidorDesligou);
            servidor.clienteConectou += new ServidorTCP.EventoIS(servidor_clienteConectou);
            servidor.clienteDesconectou += new ServidorTCP.EventoI(servidor_clienteDesconectou);
            servidor.clienteEnviou += new ServidorTCP.EventoIAB(servidor_clienteEnviou);

            cliente.clienteLigou += new ClienteTCP.EventoV(cliente_clienteLigou);
            cliente.clienteFalhou += new ClienteTCP.EventoV(cliente_clienteFalhou);
            cliente.clienteDesligou += new ClienteTCP.EventoV(cliente_clienteDesligou);
            cliente.servidorEnviou += new ClienteTCP.EventoAB(cliente_servidorEnviou);
        }

        #region Eventos Cliente
        void cliente_servidorEnviou(byte[] Buffer)
        {
            Invoke((MethodInvoker)delegate { servidorEnviou(Buffer); });
        }

        void servidorEnviou(byte[] Buffer)
        {
            string tmpStr = NetAuxiliar.bytesToString(Buffer);

            if (tmpStr.StartsWith("autent:"))
            {
                Jogo.autenticarJogador(1, tmpStr.Substring("autent:".Length));
            }
            else if (tmpStr.StartsWith("jogada:"))
            {
                Jogo.setJogada(1, (FrmJP.JPTipo)int.Parse(tmpStr.Substring("jogada:".Length)));
            }
        }

        void cliente_clienteDesligou()
        {
            Invoke((MethodInvoker)delegate { clienteDesligou(); });
        }

        void clienteDesligou()
        {
            Text = "Joquempô";
            Visible = true;
            setControlsEnabled(true);
        }

        void cliente_clienteFalhou()
        {
            Invoke((MethodInvoker)delegate { clienteFalhou(); });
        }

        void clienteFalhou()
        {
            Text = "Joquempô";
            setControlsEnabled(true);
            Visible = true;
            if (Jogo != null)
                Jogo.Close();
            MessageBox.Show("Houve uma Falha na conexão com o servidor.");
        }

        void cliente_clienteLigou()
        {
            Invoke((MethodInvoker)delegate { clienteLigou(); });
        }

        void clienteLigou()
        {
            Visible = false;
            Jogo = new FrmJP(this);
            Jogo.autenticarJogador(2, TxtNome.Text);
            Jogo.MeuNumJogador = 2;
            Jogo.Show();

            cliente.EnviarBytes(NetAuxiliar.stringToBytes("autent:" + TxtNome.Text));
        }
        #endregion

        #region Eventos Servidor
        void servidor_clienteEnviou(int Id, byte[] Buffer)
        {
            Invoke((MethodInvoker)delegate { clienteEnviou(Id, Buffer); });
        }

        void clienteEnviou(int Id, byte[] Buffer)
        {
            string tmpStr = NetAuxiliar.bytesToString(Buffer);

            if (tmpStr.StartsWith("autent:"))
            {
                Jogo.autenticarJogador(2, tmpStr.Substring("autent:".Length));
            }
            else if (tmpStr.StartsWith("jogada:"))
            {
                Jogo.setJogada(2, (FrmJP.JPTipo)int.Parse(tmpStr.Substring("jogada:".Length)));
            }
        }

        void servidor_clienteDesconectou(int Id)
        {
            Invoke((MethodInvoker)delegate { clienteDesconectou(Id); });
        }

        void clienteDesconectou(int Id)
        {
            Jogo.jogadorDesconectou(2); //2 é o cliente
        }

        void servidor_clienteConectou(int Id, string IP)
        {
            Invoke((MethodInvoker)delegate { clienteConectou(Id, IP); });
        }

        void clienteConectou(int Id, string IP)
        {
            servidor.EnviarBytes(Id, NetAuxiliar.stringToBytes("autent:" + TxtNome.Text));
        }

        void servidor_servidorDesligou()
        {
            Invoke((MethodInvoker)delegate { servidorDesligou(); });
        }

        void servidorDesligou()
        {
            Text = "Joquempô";
            Visible = true;
            setControlsEnabled(true);
        }

        void servidor_servidorFalhou()
        {
            Invoke((MethodInvoker)delegate { servidorFalhou(); });
        }

        void servidorFalhou()
        {
            Text = "Joquempô";
            setControlsEnabled(true);
            Visible = true;
            if (Jogo != null)
                Jogo.Close();
            MessageBox.Show("Falha no Servidor.");
        }

        void servidor_servidorLigou()
        {
            Invoke((MethodInvoker)delegate { servidorLigou(); });
        }

        void servidorLigou()
        {
            Visible = false;
            Jogo = new FrmJP(this);
            Jogo.autenticarJogador(1, TxtNome.Text);
            Jogo.MeuNumJogador = 1;
            Jogo.Show();
        }
        #endregion

        public void desligarServidor()
        {
            servidor.Desligar();
        }

        public void desligarCliente()
        {
            cliente.Desligar();
        }

        public void EnviaJogada(int NumJogador, FrmJP.JPTipo Jogada)
        {
            switch (NumJogador)
            {
                case 1:
                    servidor.EnviarBytes(0, NetAuxiliar.stringToBytes("jogada:" + (int)Jogada));
                    break;
                case 2:
                    cliente.EnviarBytes(NetAuxiliar.stringToBytes("jogada:" + (int)Jogada));
                    break;
            }
        }

        void setControlsEnabled(bool Enabled)
        {
            TxtIp.Enabled = Enabled;
            TxtNome.Enabled = Enabled;
            BtnConectar.Enabled = Enabled;
            BtnHost.Enabled = Enabled;
        }

        void Txt_TextChanged(object sender, EventArgs e)
        {
            if (TxtIp.Text == "" || TxtNome.Text == "")
                BtnConectar.Enabled = BtnHost.Enabled = false;
            else
                BtnConectar.Enabled = BtnHost.Enabled = true;
        }

        void BtnHost_Click(object sender, EventArgs e)
        {
            if (!servidor.Ligado)
            {
                try
                {
                    setControlsEnabled(false);
                    Text = "Iniciando Servidor...";
                    servidor.Ligar(7777);
                }
                catch { Text = "Joquempô"; }
            }
            else
                servidor.Desligar();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (!cliente.Ligado)
            {
                try
                {
                    setControlsEnabled(false);
                    Text = "Conectando ao Servidor...";
                    cliente.Ligar(TxtIp.Text, 7777);
                }
                catch { Text = "Joquempô"; }
            }
            else
                cliente.Desligar();
        }
    }
}
