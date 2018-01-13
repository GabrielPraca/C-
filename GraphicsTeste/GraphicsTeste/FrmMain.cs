using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace GraphicsTeste
{
    public partial class FrmMain : Form
    {
        [DllImport("kernel32.dll")]
        static extern uint GetTickCount();
        [DllImport("User32.dll")]
        static extern int GetKeyState(byte VirtualKey);

        public FrmMain()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            Cursor.Hide();

            Thread RenderTh = new Thread(new ThreadStart(Render));
            RenderTh.IsBackground = true;
            RenderTh.Priority = ThreadPriority.Highest;
            RenderTh.Start();
        }

        private void Render()
        {
            Thread.Sleep(1000);
            BufferedGraphics Buffer = BufferedGraphicsManager.Current.Allocate(CreateGraphics(), Screen.PrimaryScreen.Bounds);
            Graphics G = Buffer.Graphics;
            string BufStr;
            uint Tick = GetTickCount();
            int RenderVeloc = 1000;
            Bitmap Fundo = (Bitmap)Image.FromFile(Application.StartupPath + "\\Recursos\\fundo.jpg");
            float fundoX = 0;

            while (true)
            {
                float Avanco = (float)(GetTickCount() - Tick) / RenderVeloc;
                Tick = GetTickCount();
                Font fonte = new Font("Arial Black", 12);

                G.Clear(Color.Black);
                fundoX += Avanco * (float)(MousePosition.Y * MousePosition.Y * 0.1);
                if (fundoX > Width)
                    fundoX = -Width + (fundoX % Width);

                //G.FillRectangle(new SolidBrush(Color.FromArgb(Math.Abs(((int)(GetTickCount() / 2) % 511) - 255), Color.White)), 0, 0, Width, Height);
                
                G.DrawImage(Fundo, fundoX, 0, Width, Height);
                
                Point ponto = new Point(MousePosition.X - Location.X, MousePosition.Y - Location.Y);
                G.DrawLine(new Pen(Color.Red, 2), Width / 2, Height / 2, ponto.X, ponto.Y);
                G.FillRectangle(Brushes.Lime, ponto.X - 2, ponto.Y - 2, 5, 5);
                G.DrawString("X: " + MousePosition.X + " Y: " + MousePosition.Y, fonte, Brushes.Blue, ponto.X, ponto.Y - 12);
                
                #region CalcularFPS
                BufStr = string.Format("{0:00} FPS", 1000 / (RenderVeloc * Avanco));
                G.DrawString(BufStr, fonte, Brushes.Black, 1, 1);
                G.DrawString(BufStr, fonte, Brushes.Yellow, 0, 0);
                #endregion
                try
                {
                    Buffer.Render();
                }
                catch {};
                if (GetKeyState(27) < 0)
                {
                    Application.Exit();
                    Thread.CurrentThread.Abort();
                }
            }
        }
    }
}
