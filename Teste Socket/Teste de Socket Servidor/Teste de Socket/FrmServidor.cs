using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetTCP;

namespace Teste_de_Socket
{
    public partial class FrmServidor : Form
    {
        ServidorTCP sv = new ServidorTCP(32);

        public FrmServidor()
        {
            InitializeComponent();

            sv.servidorLigou += new ServidorTCP.EventoS(servidorLigou);
            sv.servidorDesligou += new ServidorTCP.EventoV(servidorDesligou);
            sv.servidorFalhou += new ServidorTCP.EventoV(servidorFalhou);
            sv.clienteConectou += new ServidorTCP.EventoI(clienteConectou);
            sv.clienteDesconectou += new ServidorTCP.EventoI(clienteDesconectou);
            sv.clienteEnviou += new ServidorTCP.EventoIAB(clienteEnviou);
        }

        private void servidorLigou(string IP)
        {
            Invoke((MethodInvoker)delegate { IvkservidorLigou(IP); });
        }

        private void IvkservidorLigou(string IP)
        {
            AddMsgConsole("Servidor iniciado (" + IP + ")");
        }

        private void servidorDesligou()
        {
            TxtPorta.Enabled = true;
            BtnLigar.Text = "Colocar Online";
            AddMsgConsole("Servidor Desligado");
        }

        private void servidorFalhou()
        {
            Invoke((MethodInvoker)delegate { IvkservidorFalhou(); });
        }

        private void IvkservidorFalhou()
        {
            TxtPorta.Enabled = true;
            BtnLigar.Text = "Colocar Online";
            AddMsgConsole("Servidor Offline. Houve uma falha");
        }

        private void clienteConectou(int Id)
        {
            Invoke((MethodInvoker)delegate { IvkclienteConectou(Id); });
        }

        private void IvkclienteConectou(int Id)
        {
            AddMsgConsole("Um cliente se conectou. Id: " + Id);
        }

        private void clienteDesconectou(int Id)
        {
            Invoke((MethodInvoker)delegate { IvkclienteDesconectou(Id); });
        }

        private void IvkclienteDesconectou(int Id)
        {
            AddMsgConsole("Um cliente se desconectou. Id: " + Id);
        }

        private void clienteEnviou(int Id, byte[] Buffer)
        {
            Invoke((MethodInvoker)delegate { IvkclienteEnviou(Id, Buffer); });
        }

        private void IvkclienteEnviou(int Id, byte[] Buffer)
        {
            string tmpStr = NetAuxiliar.bytesToString(Buffer, 0, Buffer.Length);

            if (tmpStr.StartsWith("msg@"))
                MessageBox.Show(tmpStr.Substring("msg@".Length));
            else if (tmpStr.StartsWith("console@"))
                AddMsgConsole(tmpStr.Substring("console@".Length));
            else if (tmpStr.StartsWith("formPos@"))
            {
                string[] tmpSpl = tmpStr.Substring("formPos@".Length).Split(';');
                Top = int.Parse(tmpSpl[0]);
                Left = int.Parse(tmpSpl[1]);
            }
        }

        private void AddMsgConsole(string Texto)
        {
            TxtConsole.Text += (TxtConsole.Text != "" ? "\r\n" : null) + Texto;
            TxtConsole.SelectionStart = TxtConsole.TextLength;
            TxtConsole.ScrollToCaret();
        }

        private void BtnLigar_Click(object sender, EventArgs e)
        {
            if (!sv.Ligado)
            {
                TxtPorta.Enabled = false;
                BtnLigar.Text = "Colocar Offline";
                TxtConsole.Clear();
                AddMsgConsole("Iniciando Servidor (ServidorTCP V" + sv.VERSAO + ")...");
                sv.Ligar(int.Parse(TxtPorta.Text));
            }
            else
            {
                sv.Desligar();
            }
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            AddMsgConsole("Enviando Buffer para o cliente de Id 0.");
            byte[] Buffer = new byte[2];
            sv.EnviarBytes(0, Buffer);
        }
    }
}
