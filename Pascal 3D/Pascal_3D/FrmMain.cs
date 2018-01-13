using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Pascal_3D
{
    public partial class FrmMain : Form
    {
        const float rad = (float)Math.PI / 180;

        Point3D[,] data = new Point3D[2560, 2560];
        int t1, t2;
        Base2D Base;
        float e;
        bool perspective;
        Graphics G;

        public FrmMain()
        {
            InitializeComponent();

            Thread Th = new Thread(new ThreadStart(Render));
            Th.IsBackground = true;
            Th.Start();
        }

        void spher_to_cartesian(int radius, float a, float b, ref Point3D p)
        {
            float s1, s2, c1, c2;

            s1 = (float)Math.Sin(a * rad);
            s2 = (float)Math.Sin(b * rad);
            c1 = (float)Math.Cos(a * rad);
            c2 = (float)Math.Cos(b * rad);
            p.x = radius * c1 * c2;
            p.y = radius * c1 * s2;
            p.z = radius * s1;
        }

        void Rotate(float angleX, float angleY, float angleZ, ref Point3D p)
        {
            float s1, s2, s3, c1, c2, c3;
            Point3D Puit = new Point3D();

            s1 = (float)Math.Sin(angleX * rad);
            s2 = (float)Math.Sin(angleY * rad);
            s3 = (float)Math.Sin(angleZ * rad);
            c1 = (float)Math.Cos(angleX * rad);
            c2 = (float)Math.Cos(angleY * rad);
            c3 = (float)Math.Cos(angleZ * rad);
            Puit.x = p.x * (c2 * c3) + p.y * (c2 * s3) - p.z * s2;
            Puit.y = p.x * (s1 * s2 * c3 - c1 * s3) + p.y * (s1 * s2 * s3 + c1 * c3) + p.z * (s1 * c2);
            Puit.z = p.x * (c1 * s2 * c3 + s1 * s3) + p.y * (c1 * s2 * s3 - s1 * c3) + p.z * (c1 * c2);
            p = Puit;
        }

        void init(int radius, int hor, int ver, int hx, int hy, int hz)
        {
            Point3D p1 = new Point3D(), p2 = new Point3D();
            float a, b, hor_step, ver_step;

            t1 = 0;
            hor_step = 180f / hor;
            ver_step = 360f / ver;
            for (int i = 0; i <= hor; i++)
            {
                b = 0;
                a = -90 + i * hor_step;
                spher_to_cartesian(radius, a, b, ref p1);
                Rotate (hx, hy, hz, ref p1);
                t2 = 0;
                t1++;
                data[t1, t2] = p1;
                for (int j = 0; j <= ver; j++)
                {
                    t2++;
                    b = j * ver_step;
                    spher_to_cartesian(radius, a, b, ref p2);
                    Rotate (hx, hy, hz, ref p2);
                    data[t1, t2] = p2;
                }
            }
        }

        void Rotation(float x, float y, float z)
        {
            float s1, s2, s3, c1, c2, c3;
            Point3D p, Puit;

            s1 = (float)Math.Sin(x * rad);
            s2 = (float)Math.Sin(y * rad);
            s3 = (float)Math.Sin(z * rad);
            c1 = (float)Math.Cos(x * rad);
            c2 = (float)Math.Cos(y * rad);
            c3 = (float)Math.Cos(z * rad);
            for (int u = 0; u <= t1; u++)
                for (int v = 0; v <= t2; v++)
                {
                    p = data[u, v];
                    Puit.x = p.x * (c2 * c3) + p.y * (c2 * s3) - p.z * s2;
                    Puit.y = p.x * (s1 * s2 * c3 - c1 * s3) + p.y *
                           (s1 * s2 * s3 + c1 * c3) + p.z * (s1 * c2);
                    Puit.z = p.x * (c1 * s2 * c3 + s1 * s3) + p.y *
                           (c1 * s2 * s3 - s1 * c3) + p.z * (c1 * c2);
                    data[u, v] = Puit;
                }
        }

        void TransForm(Point3D Pt3D, ref float X2D, ref float Y2D)
        {
            float thit;
            if (perspective)
            {
                thit = 1 / (1 - Pt3D.x / e);
                X2D = Base.u + Pt3D.y * thit;
                Y2D = Base.v + Pt3D.z * thit;
            }
            else
            {
                X2D = Base.u + Pt3D.y;
                Y2D = Base.v + Pt3D.z;
            }
        }

        void Line3(Point3D point1, Point3D point2)
        {
            float x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            TransForm(point1, ref x1, ref y1);
            TransForm(point2, ref x2, ref y2);
            G.DrawLine(Pens.Yellow, x1, y1, x2, y2);
        }

        void Draw()
        {
            for (int u = 1; u < t2; u++)
                for (int v = 1; v < t1; v++)
                {
                    Line3(data[v, u], data[v + 1, u]);
                    Line3(data[v, u], data[v, u + 1]);
                }
        }

        void Render()
        {
            Thread.Sleep(1000);

            BufferedGraphics Buffer = BufferedGraphicsManager.Current.Allocate(CreateGraphics(), DisplayRectangle);
            G = Buffer.Graphics;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Base.u = Width / 2;
            Base.v = Height / 2;
            perspective = false;
            e = 150;

            while (true)
            {
                G.Clear(BackColor);
                Rotation(-0.5f, 0.5f, 3);
                Draw();
                Buffer.Render();
            }
        }

        struct Point3D {
            public float x, y, z;
        }

        struct Base2D {
            public float u, v;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            init(150, e.X, e.Y, 40, -55, 14);
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            perspective = !perspective;
        }
    }
}
