using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace Teste_de_Thread
{
    public partial class FrmMain : Form
    {
        Thread ThCopia;
        FileStream Arquivo;

        [DllImport("Kernel32.dll")]
        public static extern uint GetTickCount();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (ThCopia != null)
            {
                ThCopia.Abort();
                ThCopia.Join();
                Arquivo.Close();
            }
            Text = "0% (0,00MB/s)";
            ThCopia = new Thread(new ThreadStart(TesteThread));
            ThCopia.IsBackground = true;
            ThCopia.Start();
        }

        private void TesteThread()
        {
            uint MB = 1024 * 1024;
            byte[] Buffer = new byte[MB * 8];
            uint Durac = GetTickCount();
            uint iFim = (MB * 1024) / (uint)Buffer.Length;
            long Tamanho = 0;
            List<float> MVeloc = new List<float>();

            Arquivo = new FileStream(Application.StartupPath + "\\tmp.bin", FileMode.Create, FileAccess.ReadWrite);
            uint Tick = GetTickCount();

            try
            {
                for (uint i = 0; i < iFim; i++)
                {
                    Arquivo.Write(Buffer, 0, Buffer.Length);
                    if (GetTickCount() - Tick >= 100)
                    {
                        int Prog = (int)((double)i * 100 / iFim);
                        float Veloc = (float)(Arquivo.Length - Tamanho) / ((float)(GetTickCount() - Tick) / 1000);
                        Veloc /= 1024 * 1024;
                        MVeloc.Add(Veloc);
                        PgbStatus.Invoke((MethodInvoker)delegate { AtualizarProgresso(Prog, Veloc); });
                        Tick = GetTickCount();
                        Tamanho = Arquivo.Length;
                    }
                }
            }
            catch { }
            Arquivo.Close();
            Durac = GetTickCount() - Durac;
            File.Delete(Arquivo.Name);

            float MediaV = 0;
            foreach (float valor in MVeloc)
                MediaV += valor;
            MediaV /= MVeloc.Count;

            PgbStatus.Invoke((MethodInvoker)delegate { AtualizarProgresso(100, MediaV); });
            MessageBox.Show(string.Format("Arquivo Concluído em {0}ms. Velocidade média: {1:0.00}MB/s!", Durac, MediaV));
        }

        private void AtualizarProgresso(int Progresso, float Veloc)
        {
            PgbStatus.Value = Progresso;
            Text = string.Format("{0}% ({1:0.00}MB/s)", Progresso, Veloc);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ThCopia != null)
            {
                Text = "Teste de Escrita - Fechando...";
                ThCopia.Abort();
                ThCopia.Join();
                Arquivo.Close();
                File.Delete(Arquivo.Name);
            }
        }
    }
}
