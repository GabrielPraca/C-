using System;
using System.Text;
using System.Threading;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Hora.Net
{
    public partial class FrmMain : Form
    {
        [DllImport("Kernel32.dll")]
        static extern bool SetSystemTime(ref SystemTime Time);

        public FrmMain()
        {
            InitializeComponent();

            Thread Th = new Thread(new ThreadStart(() => {
                try
                {
                    string[] Servidores = File.ReadAllLines(Application.StartupPath + @"\Servidores.ini");

                    foreach (string Servidor in Servidores)
                    {
                        try
                        {
                            SetStatus(string.Format("Tentando atualizar a hora pelo servidor: \"{0}\"", Servidor));
                            Socket Conexao = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            IAsyncResult conStatus = Conexao.BeginConnect(new IPEndPoint(Dns.GetHostEntry(Servidor).AddressList[0], 13), null, null);
                            if (conStatus.AsyncWaitHandle.WaitOne(5000, true))
                            {
                                byte[] Buffer = new byte[Conexao.ReceiveBufferSize];

                                int Len = Conexao.Receive(Buffer);
                                string Resposta = Encoding.ASCII.GetString(Buffer, 0, Len);
                                Conexao.Disconnect(true);

                                //Processa a resposta
                                Console.Write("Servidor: " + Servidor + " Resposta: " + Resposta);
                                string[] STime = Resposta.Split(' ');
                                string[] SData = STime[1].Split('-');
                                string[] SHora = STime[2].Split(':');
                                DateTime Time = new DateTime(2000 + int.Parse(SData[0]), int.Parse(SData[1]), int.Parse(SData[2]), int.Parse(SHora[0]), int.Parse(SHora[1]), int.Parse(SHora[2]));
                                SystemTime SysTime = new SystemTime(Time);
                                bool res = SetSystemTime(ref SysTime);

                                if (res)
                                {
                                    SetStatus("Horário ajustado com sucesso!\r\nServidor: " + Servidor);
                                    Thread.Sleep(3000);
                                    Application.Exit();
                                }
                            }
                        }
                        catch { }
                    }
                }
                catch { }

                SetStatus("Não foi possível ajustar o horário.");
                Thread.Sleep(3000);
                Application.Exit();
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        void SetStatus(string Status)
        {
            this.Invoke((MethodInvoker)delegate { LblServidor.Text = Status; });
        }

        struct SystemTime
        {
            public short Year;
            public short Month;
            public short DayOfWeek;
            public short Day;
            public short Hour;
            public short Minute;
            public short Second;
            public short Millisecond;

            public SystemTime(DateTime Time)
            {
                this.Year = (short)Time.Year;
                this.Month = (short)Time.Month;
                this.DayOfWeek = (short)Time.DayOfWeek;
                this.Day = (short)Time.Day;
                this.Hour = (short)Time.Hour;
                this.Minute = (short)Time.Minute;
                this.Second = (short)Time.Second;
                this.Millisecond = (short)Time.Millisecond;
            }
        }
    }
}
