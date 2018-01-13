using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetTCP;
using System.Text;
using System.Windows.Forms;
 
namespace Teste_socket_Cliente 
{
    public partial class FrmCliente : Form 
    {
        ClienteTCP cliente = new ClienteTCP();

        public FrmCliente()
        {
            InitializeComponent();
            
            cliente.clienteLigou += new ClienteTCP.EventoV(clienteLigou);
            cliente.clienteDesligou += new ClienteTCP.EventoV(clienteDesligou);
            cliente.clienteFalhou += new ClienteTCP.EventoV(clienteFalhou);
            cliente.servidorEnviou += new ClienteTCP.EventoAB(servidorEnviou);
        }

        private void clienteLigou()
        {
            Invoke((MethodInvoker)delegate { IvkclienteLigou(); });
        }

        private void IvkclienteLigou()
        {
            AddMsgConsole("Cliente conectado");
            cliente.EnviarBytes(NetAuxiliar.stringToBytes("ident:\nnome:" + System.Environment.UserName));
        }

        private void clienteDesligou()
        {
            Invoke((MethodInvoker)delegate { IvkclienteDesligou(); });
        }

        private void IvkclienteDesligou()
        {
            BtnConectar.Text = "Conectar";
            TxtIP.Enabled = true;
            AddMsgConsole("Cliente desconectado");
        }

        private void clienteFalhou()
        {
            Invoke((MethodInvoker)delegate { IvkclienteFalhou(); });
        }

        private void IvkclienteFalhou()
        {
            BtnConectar.Text = "Conectar";
            TxtIP.Enabled = true;
            AddMsgConsole("Cliente Offline. Houve uma falha");
        }

        private void servidorEnviou(byte[] Buffer)
        {
            Invoke((MethodInvoker)delegate { IvkservidorEnviou(Buffer); });
        }

        private void IvkservidorEnviou(byte[] Buffer)
        {
            AddMsgConsole(NetAuxiliar.bytesToString(Buffer));
        }

        private void AddMsgConsole(string Texto)
        {
            TxtConsole.Text += (TxtConsole.Text != "" ? "\r\n" : null) + Texto;
            TxtConsole.SelectionStart = TxtConsole.TextLength;
            TxtConsole.ScrollToCaret();
        }

        private void PnlTela_MouseMove(object sender, MouseEventArgs e)
        {
            cliente.EnviarBytes(NetAuxiliar.stringToBytes("formPos@" +
                                              (int)(e.Y * (Screen.PrimaryScreen.Bounds.Width / PnlTela.Height)) +
                                              ";" +
                                              (int)(e.X * (Screen.PrimaryScreen.Bounds.Width / PnlTela.Width))));
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            if (!cliente.Ligado)
            {
                BtnConectar.Text = "Desconectar";
                TxtIP.Enabled = false;
                string[] IpPorta = TxtIP.Text.Split(':');
                TxtConsole.Clear();
                AddMsgConsole("Conectando ao servidor...");
                try { cliente.Ligar(IpPorta[0], int.Parse(IpPorta[1])); }
                catch { AddMsgConsole("O formato do IP:Porta está inválido"); }
            }
            else { cliente.Desligar(); }
        }
    }
}