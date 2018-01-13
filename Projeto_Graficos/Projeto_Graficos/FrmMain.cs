using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Graficos
{
    public partial class FrmMain : Form
    {
        Bitmap GraficoBuf;
        int offsetG1 = 0;
        int posAnt;
        int movimento = 1;

        public FrmMain()
        {
            InitializeComponent();
            GraficoBuf = new Bitmap(3001, PnlGrafico.Height);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Graphics Grafico = Graphics.FromImage(GraficoBuf);
            Grafico.Clear(Color.White);

            float offsetY = GraficoBuf.Height / 10f,
                offsetX = 10f,
                MAX_X = GraficoBuf.Width,
                MAX_Y = GraficoBuf.Height;
            for (float y = 0; y <= MAX_Y; y += offsetY)
                Grafico.DrawLine(Pens.Gray, 0, y, MAX_X, y);
            for (float x = 0; x <= MAX_X; x += offsetX)
                Grafico.DrawLine(Pens.Gray, x, 0, x, MAX_Y);
            Brush cor = new SolidBrush(Color.FromArgb(100, 255, 0, 0));
            int MAX_LEN = 3000;
            Point[] linhas = new Point[MAX_LEN + 2];
            Random rdn = new Random();
            for (int i = 0; i < MAX_LEN; i++)
                linhas[i] = new Point(i, (int)(MAX_Y - MAX_Y * Math.Sin(i * 0.05)) / 2);
            Point[] linhasFill = new Point[MAX_LEN + 2];
            Array.Copy(linhas, linhasFill, linhas.Length);
            linhas[MAX_LEN] = linhas[MAX_LEN - 1];
            linhas[MAX_LEN + 1] = linhas[MAX_LEN - 1];
            linhasFill[MAX_LEN] = new Point(linhas[MAX_LEN - 1].X, (int)MAX_Y - 1);
            linhasFill[MAX_LEN + 1] = new Point(0, (int)MAX_Y - 1);
            Grafico.FillPolygon(cor, linhasFill);
            Grafico.DrawLines(new Pen(Brushes.Red, 3), linhas);
            Grafico.DrawLine(Pens.Gray, 0, MAX_Y - 1, MAX_X, MAX_Y - 1);
            Grafico.DrawLine(Pens.Gray, 0, 0, 0, MAX_Y);
        }

        private void PnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            PnlGrafico.CreateGraphics().DrawImage(GraficoBuf, -offsetG1, 0);
        }

        private void PnlGrafico_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offsetG1 += (int)posAnt - e.Location.X;
                if (offsetG1 > GraficoBuf.Width - PnlGrafico.Width)
                    offsetG1 = GraficoBuf.Width - PnlGrafico.Width;
                if (offsetG1 < 0)
                    offsetG1 = 0;
                LblOffset.Text = "OFFSET: " + offsetG1;
                PnlGrafico_Paint(null, null);
            }
            posAnt = e.Location.X;
        }

        private void TimMovimento_Tick(object sender, EventArgs e)
        {
            offsetG1 += movimento;
            if (offsetG1 > GraficoBuf.Width - PnlGrafico.Width)
            {
                offsetG1 = GraficoBuf.Width - PnlGrafico.Width;
                movimento *= -1;
            }
            if (offsetG1 < 0)
            {
                offsetG1 = 0;
                movimento *= -1;
            }
            LblOffset.Text = "OFFSET: " + offsetG1;
            PnlGrafico_Paint(null, null);
        }
    }
}
