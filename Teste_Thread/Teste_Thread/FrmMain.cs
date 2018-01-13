using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Teste_Thread
{
    public partial class FrmMain : Form
    {
        BufferedGraphics Buffer;
        Graphics G;
        int[] vetor;
        Random rdn = new Random();
        Thread Th;

        public FrmMain()
        {
            InitializeComponent();
            Buffer = BufferedGraphicsManager.Current.Allocate(PnlGraf.CreateGraphics(), PnlGraf.DisplayRectangle);
            G = Buffer.Graphics;
            vetor = new int[PnlGraf.Width];

            desenhaVetor();
            Buffer.Render();
        }

        private void PnlGraf_Paint(object sender, PaintEventArgs e)
        {
            if (Th == null || Th.ThreadState != ThreadState.Background)
                Buffer.Render();
        }

        void desenhaVetor()
        {
            try
            {
                G.Clear(Color.Black);
                lock (vetor)
                    for (int i = 0; i < vetor.Length; i++)
                        G.FillRectangle(Brushes.White, i, PnlGraf.Height - 1 - vetor[i], 1, 1);
            } catch { }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            if (Th != null)
            {
                Th.Abort();
                Th.Join();
            }
            lock (vetor)
            {
                for (int i = 0; i < vetor.Length; i++)
                    vetor[i] = rdn.Next(PnlGraf.Height);
            }
            desenhaVetor();
            Buffer.Render();
        }

        void ThOrganizaBubble()
        {
            for (int ii = 0; ii < vetor.Length; ii++)
            {
                for (int i = 0; i < vetor.Length - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        //Troca de posição com o método "Swap XOR"
                        vetor[i] ^= vetor[i + 1];
                        vetor[i + 1] ^= vetor[i];
                        vetor[i] ^= vetor[i + 1];
                    }
                }
                desenhaVetor();
                Invoke((MethodInvoker)delegate { Buffer.Render(); });
            }
        }

        void ThOrganizaSelection()
        {
            int min, aux;

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
                desenhaVetor();
                Invoke((MethodInvoker)delegate { Buffer.Render(); });
            }
        }

        void Organizar(ThreadStart ThS)
        {
            if (Th != null)
            {
                Th.Abort();
                Th.Join();
            }

            Th = new Thread(ThS);
            Th.IsBackground = true;
            Th.Priority = ThreadPriority.Lowest;
            Th.Start();
        }

        private void BtnOrgBubble_Click(object sender, EventArgs e)
        {
            Organizar(new ThreadStart(ThOrganizaBubble));
        }

        private void BtnOrgSelec_Click(object sender, EventArgs e)
        {
            Organizar(new ThreadStart(ThOrganizaSelection));
        }
    }
}
