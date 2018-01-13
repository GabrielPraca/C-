using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace System.Net.NetTCP
{
    class ServidorTCP
    {
        public readonly int MAX_BUFFER = 0xFFFF;
        public readonly string VERSAO = "1.0";

        int Porta { get; set; }
        public bool Ligado { get; private set; }
        public ushort MAX_CLIENTES { get; private set; }
        public ushort clientesConectados { get; private set; }

        public delegate void EventoV();
        public event EventoV servidorLigou, servidorDesligou, servidorFalhou;

        public delegate void EventoIS(int N1, string S1);
        public event EventoIS clienteConectou;

        public delegate void EventoI(int N1);
        public event EventoI clienteDesconectou;

        public delegate void EventoIAB(int N1, byte[] B1);
        public event EventoIAB clienteEnviou;

        TcpListener servidor;
        Cliente[] Clientes;

        public ServidorTCP(ushort MAX_CLIENTES)
        {
            this.MAX_CLIENTES = MAX_CLIENTES;
            Clientes = new Cliente[MAX_CLIENTES];
            clientesConectados = 0;
        }

        public void Ligar(int Porta)
        {
            if (Ligado)
                return;
            else
            {
                Ligado = true;
                this.Porta = Porta;
            }

            Thread Th = new Thread(new ThreadStart(ExecutarServidor));
            Th.IsBackground = true;
            Th.Start();
        }

        public void Desligar()
        {
            if (!Ligado)
                return;
            else
            {
                try
                {
                    servidor.Stop();
                    Ligado = false;
                    lock (Clientes)
                    {
                        for (int i = 0; i < Clientes.Length; i++)
                        {
                            if (Clientes[i] != null)
                            {
                                Clientes[i].Desconectar();
                                Clientes[i] = null;
                            }
                        }
                        clientesConectados = 0;
                    }
                    servidorDesligou();
                }
                catch { }
            }
        }

        public void EnviarBytes(int Id, byte[] Buffer)
        {
            if (Clientes[Id] != null)
            {
                ThParamEnvio param = new ThParamEnvio();
                param.cli = Clientes[Id];
                param.Buffer = Buffer;

                Thread Th = new Thread(new ParameterizedThreadStart(ThreadEnviarBytes));
                Th.IsBackground = true;
                Th.Priority = ThreadPriority.Highest;
                Th.Start(param);
            }
        }

        private void ThreadEnviarBytes(object Parametro)
        {
            ThParamEnvio param = (ThParamEnvio)Parametro;

            lock (param.cli)
            {
                byte[] Buffer = new byte[2 + param.Buffer.Length];
                Buffer[0] = (byte)(param.Buffer.Length >> 8);
                Buffer[1] = (byte)(param.Buffer.Length & 0xFF);
                param.Buffer.CopyTo(Buffer, 2);

                try { param.cli.Writer.Write(Buffer); }
                catch { }
            }
        }

        public void DesconectarCliente(int Id)
        {
            if (Ligado)
            {
                try
                {
                    lock (Clientes)
                    {
                        Clientes[Id].Desconectar();
                        Clientes[Id] = null;
                    }
                    clientesConectados--;
                    try { clienteDesconectou(Id); }
                    catch { }
                }
                catch { }
            }
        }

        private void EscutarCliente(object _Cli)
        {
            Cliente Cli = (Cliente)_Cli;
            int Id = -1;
            lock (Clientes)
            {
                for (int i = 0; i < Clientes.Length; i++)
                {
                    if (Clientes[i] == Cli)
                    {
                        Id = i;
                        break;
                    }
                }
            }

            try
            {
                while (true)
                {
                    byte[] tamanho = new byte[2];
                    tamanho[0] = Cli.Reader.ReadBytes(1)[0];
                    if (Cli.Conexao.Available > 0)
                    {
                        tamanho[1] = Cli.Reader.ReadBytes(1)[0];
                        try { clienteEnviou(Id, Cli.Reader.ReadBytes((tamanho[0] << 8) + tamanho[1])); }
                        catch { }
                    }
                    else { DesconectarCliente(Id); }
                }
            }
            catch { DesconectarCliente(Id); }
        }

        private void ExecutarServidor()
        {
            try
            {
                servidor = new TcpListener(IPAddress.Any, Porta);
                servidor.Start();
                try { servidorLigou(); }
                catch { }

                while (true)
                {
                    Cliente tmpCli = new Cliente(servidor.AcceptTcpClient());

                    if (clientesConectados < MAX_CLIENTES)
                    {
                        lock (Clientes)
                        {
                            for (int i = 0; i < Clientes.Length; i++)
                            {
                                if (Clientes[i] == null)
                                {
                                    Clientes[i] = tmpCli;
                                    clientesConectados++;
                                    try { clienteConectou(i, tmpCli.Conexao.Client.RemoteEndPoint.ToString()); }
                                    catch { }
                                    Thread Th = new Thread(new ParameterizedThreadStart(EscutarCliente));
                                    Th.IsBackground = true;
                                    Th.Start(tmpCli);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        tmpCli.Writer.Write("erro@Lotado");
                        tmpCli.Desconectar();
                    }
                }
            }
            catch
            {
                if (Ligado)
                {
                    Desligar();
                    Ligado = false;
                    try { servidorFalhou(); }
                    catch { }
                }
            }
        }

        private struct ThParamEnvio
        {
            public Cliente cli;
            public byte[] Buffer;
        }

        private class Cliente
        {
            public TcpClient Conexao;
            public BinaryReader Reader;
            public BinaryWriter Writer;

            public Cliente(TcpClient Conexao)
            {
                this.Conexao = Conexao;
                Reader = new BinaryReader(Conexao.GetStream());
                Writer = new BinaryWriter(Conexao.GetStream());
            }

            public void Desconectar()
            {
                Conexao.Client.Shutdown(SocketShutdown.Both);
                Reader.Close();
                Writer.Close();
                Conexao.Close();
            }
        }
    }

    class ClienteTCP
    {
        public readonly int MAX_BUFFER = 0xFFFF;
        public readonly string VERSAO = "1.0";

        public bool Ligado { get { return (cliente != null ? cliente.Conexao.Connected : false); } }

        public delegate void EventoV();
        public event EventoV clienteLigou, clienteDesligou, clienteFalhou;

        public delegate void EventoAB(byte[] B1);
        public event EventoAB servidorEnviou;

        Cliente cliente;

        ~ClienteTCP()
        {
            try { cliente.Writer.Write(new byte[] { 0 }); }
            catch { }
        }

        public void Ligar(string IP, int Porta)
        {
            if (Ligado)
                return;

            Thread Th = new Thread(new ParameterizedThreadStart(ExecutarCliente));
            Th.IsBackground = true;
            Th.Start(new string[] { IP, Porta.ToString() });
        }

        private void ExecutarCliente(object IpPorta)
        {
            try
            {
                cliente = new Cliente(new TcpClient());
                cliente.Conexao.Connect(((string[])IpPorta)[0], int.Parse(((string[])IpPorta)[1]));
                cliente.Reader = new BinaryReader(cliente.Conexao.GetStream());
                cliente.Writer = new BinaryWriter(cliente.Conexao.GetStream());
                try { clienteLigou(); }
                catch { }

                while (true)
                {
                    byte[] tamanho = cliente.Reader.ReadBytes(2);
                    byte[] Buffer = cliente.Reader.ReadBytes((tamanho[0] << 8) + tamanho[1]);
                    try { servidorEnviou(Buffer); }
                    catch { }
                }
            }
            catch
            {
                try
                {
                    bool Falhou = cliente != null;
                    if (Ligado && !Falhou)
                        cliente.Desconectar();
                    if (Falhou)
                        clienteFalhou();
                }
                catch { }
            }
        }

        public void Desligar()
        {
            if (!Ligado)
                return;
            else
            {
                try
                {
                    cliente.Desconectar();
                    cliente = null;
                    clienteDesligou();
                }
                catch { }
            }
        }

        public void EnviarBytes(byte[] Buffer)
        {
            Thread Th = new Thread(new ParameterizedThreadStart(ThreadEnviarBytes));
            Th.IsBackground = true;
            Th.Priority = ThreadPriority.Highest;
            Th.Start(Buffer);
        }

        private void ThreadEnviarBytes(object Parametro)
        {
            byte[] param = (byte[])Parametro;

            try
            {
                lock (cliente.Conexao)
                {
                    byte[] Buffer = new byte[2 + param.Length];
                    Buffer[0] = (byte)(param.Length >> 8);
                    Buffer[1] = (byte)(param.Length & 0xFF);

                    for (int i = 0; i < param.Length; i++)
                        Buffer[i + 2] = param[i];

                    try { cliente.Writer.Write(Buffer); }
                    catch { }
                }
            }
            catch { }
        }

        private class Cliente
        {
            public TcpClient Conexao;
            public BinaryReader Reader;
            public BinaryWriter Writer;

            public Cliente(TcpClient Conexao)
            {
                this.Conexao = Conexao;
            }

            public void Desconectar()
            {
                lock (this)
                {
                    try { Writer.Write(new byte[] { 0 }); }
                    catch { }
                    Conexao.Client.Shutdown(SocketShutdown.Both);
                    Conexao.Close();
                    Reader.Close();
                    Writer.Close();
                }
            }
        }
    }

    class NetAuxiliar
    {
        public static string bytesToString(byte[] Bytes, int inicio, int tamanho)
        {
            char[] resultado = new char[tamanho];

            if (tamanho > 0)
            {
                int bLen = Bytes.Length;
                {
                    for (int i = 0; i < tamanho; i++)
                    {
                        if (i + inicio < bLen)
                            resultado[i] = (char)Bytes[i + inicio];
                        else
                            break;
                    }
                }
            }

            return new string(resultado);
        }

        public static string bytesToString(byte[] Bytes, int inicio)
        {
            int tamanho = Bytes.Length - inicio;
            char[] resultado = new char[tamanho];

            if (tamanho > 0)
            {
                for (int i = 0; i < tamanho; i++)
                    resultado[i] = (char)Bytes[i + inicio];
            }

            return new string(resultado);
        }

        public static string bytesToString(byte[] Bytes)
        {
            int bLen = Bytes.Length;
            char[] resultado = new char[bLen];

            if (Bytes.Length > 0)
            {
                for (int i = 0; i < bLen; i++)
                    resultado[i] += (char)Bytes[i];
            }

            return new string(resultado);
        }

        public static byte[] stringToBytes(string Texto)
        {
            byte[] resultado = new byte[Texto.Length];

            if (Texto.Length > 0)
            {
                for (int i = 0; i < Texto.Length; i++)
                    resultado[i] = (byte)Texto[i];
            }

            return resultado;
        }
    }
}