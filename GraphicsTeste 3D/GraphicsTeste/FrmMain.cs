using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        obj3D quadrado = new obj3D(new vet3D[] {new vet3D(50, -50, 150),
                                                new vet3D(50, 50, 150),
                                                new vet3D(-50, -50, 150),
                                                new vet3D(-50, 50, 150),
                                                new vet3D(50, -50, 250),
                                                new vet3D(50, 50, 250),
                                                new vet3D(-50, -50, 250),
                                                new vet3D(-50, 50, 250)},
                                   new int[] {1, 2,
                                              1, 3,
                                              3, 2,
                                              4, 2,
                                              4, 3,
                                              1, 5,
                                              1, 7,
                                              5, 7,
                                              3, 7,
                                              4, 8,
                                              2, 8,
                                              2, 6,
                                              6, 8,
                                              7, 8,
                                              7, 6,
                                              5, 6});

        Camera camera;
        Pen CorL1 = new Pen(Color.White, 3),
            CorL2 = new Pen(Color.RoyalBlue, 3);

        public FrmMain()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private vet3D Rotacionar(vet3D vertex)
        {
            double rad = Math.PI / 180;

            double dx = vertex.x - camera.x;
            double dy = vertex.y - camera.y;
            double dz = vertex.z - camera.z;

            double d1x = Math.Cos(camera.ry * rad) * dx + Math.Sin(camera.ry * rad) * dz;
            double d1y = dy;
            double d1z = Math.Cos(camera.ry * rad) * dz - Math.Sin(camera.ry * rad) * dx;

            double d2x = d1x;
            double d2y = Math.Cos(camera.rx * rad) * d1y - Math.Sin(camera.rx * rad) * d1z;
            double d2z = Math.Cos(camera.rx * rad) * d1z + Math.Sin(camera.rx * rad) * d1y;

            double d3x = Math.Cos(camera.rz * rad) * d2x + Math.Sin(camera.rz * rad) * d2y;
            double d3y = Math.Cos(camera.rz * rad) * d2y - Math.Sin(camera.rz * rad) * d2x;
            double d3z = d2z;

            return new vet3D(d3x, d3y, d3z);
        }

        private void render(obj3D obj, Camera camera)
        {
            for (int i = 0; i < obj.link.Length / 2; i++)
            {
                vet3D vertex1 = obj.vertex[obj.link[i * 2] - 1];
                vet3D vertex2 = obj.vertex[obj.link[i * 2 + 1] - 1];

                vertex1 = Rotacionar(vertex1);
                vertex2 = Rotacionar(vertex2);

                if (vertex1.z > 0 && vertex2.z > 0)
                {
                    double scale1 = camera.depth / vertex1.z;
                    float posX1 = (float)(scale1 * vertex1.x + camera.offsetX);
                    float posY1 = (float)(scale1 * vertex1.y + camera.offsetY);

                    double scale2 = camera.depth / vertex2.z;
                    float posX2 = (float)(scale2 * vertex2.x + camera.offsetX);
                    float posY2 = (float)(scale2 * vertex2.y + camera.offsetY);

                    camera.tela.DrawLine(i % 2 == 0 ? CorL1 : CorL2, posX1, posY1, posX2, posY2);
                }

                /*if (d3z > 1)
                {
                    double scale = camera.depth / d3z;
                    int posX = (int)(scale * d3x + camera.offsetX);
                    int posY = (int)(scale * d3y + camera.offsetY);
                    int size = (int)(scale * 10);
                    if (!opera)
                        camera.tela.FillRectangle(Brushes.Red, posX - size / 2, posY - size / 2, size, size);
                    else
                        camera.tela.DrawImage(ponto, posX - size / 2, posY - size / 2, size, size);
                }*/
            }
        }

        private void ThRender()
        {
            Thread.Sleep(1000);
            uint Tick = GetTickCount();
            BufferedGraphics Buffer = BufferedGraphicsManager.Current.Allocate(CreateGraphics(), Screen.PrimaryScreen.Bounds);
            Graphics G = Buffer.Graphics;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int Width = (int)G.VisibleClipBounds.Width,
                Height = (int)G.VisibleClipBounds.Height;
            Font Fonte = new Font("Arial Black", 16);

            camera = new Camera(0, 0, 0, 500, Buffer.Graphics, Width, Height);

            while (true)
            {
                float FPS = 0;
                try { FPS = 1000 / (float)(GetTickCount() - Tick); }
                catch { }
                Tick = GetTickCount();
                camera.tela.Clear(Color.MediumBlue);
                camera.SetRotation(camera.rx, camera.ry - (Width / 2 - MousePosition.X) * 0.01, camera.rz);
                camera.SetPosition(camera.x, camera.y, (-MousePosition.Y * 0.5) + 200);
                render(quadrado, camera);
                G.DrawString(string.Format("{0:00} FPS", FPS), Fonte, Brushes.Yellow, 0, 0);
                G.DrawString(string.Format("RY: {0:0.00}", (camera.ry + 360) % 360), Fonte, Brushes.Yellow, 0, 20);

                Buffer.Render();
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Thread Th = new Thread(new ThreadStart(ThRender));
            Th.IsBackground = true;
            Th.Start();
        }
    }

    struct obj3D
    {
        public vet3D[] vertex;
        public int[] link;

        public obj3D(vet3D[] vertexes, int[] links)
        {
            vertex = vertexes;
            link = links;
        }
    }

    struct vet3D
    {
        public double x, y, z;

        public vet3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    struct Camera
    {
        public double depth, offsetX, offsetY, x, y, z, rx, ry, rz;
        public int width, height;
        public Graphics tela;

        public Camera(double x, double y, double z, double depth, Graphics tela, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            rx = 0;
            ry = 0;
            rz = 0;
            this.depth = depth;
            this.tela = tela;
            this.width = width;
            this.height = height;
            offsetX = width / 2;
            offsetY = height / 2;
        }

        public void SetPosition(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void SetRotation(double rx, double ry, double rz)
        {
            this.rx = rx % 360;
            this.ry = ry % 360;
            this.rz = rz % 360;
        }
    }
}