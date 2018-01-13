using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Horario_Aula
{
    public partial class FrmCarregandoEtapa : UserControl
    {
        [DllImport("kernel32.dll")]
        static extern uint GetTickCount();

        Pen Arco = new Pen(Color.DarkRed, 10);

        public FrmCarregandoEtapa()
        {
            InitializeComponent();

            //Isso é para que a imagem não fique piscando
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            
            RefreshTimer();
        }

        void RefreshTimer()
        {
            Thread Th = new Thread(new ThreadStart(() =>
            {
                try
                {
                    MethodInvoker RefMetodo = (MethodInvoker)delegate { DrawBackground(this.CreateGraphics(), true); };

                    while (true)
                    {
                        Invoke(RefMetodo);
                        Thread.Sleep(20);
                    }
                }
                catch { }
            }));

            Th.IsBackground = true;
            Th.Start();
        }

        void DrawBackground(Graphics g, bool isGraphicsDisposable)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.FillRectangle(Brushes.White, this.Width / 2 - 32, this.Height / 2 - 32, 64, 64);
            g.DrawArc(Arco, this.Width / 2 - 16, this.Height / 2 - 16, 32, 32, GetTickCount() * 0.5f, 90);

            if (isGraphicsDisposable)
                g.Dispose();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            DrawBackground(e.Graphics, false);
        }
    }
}
