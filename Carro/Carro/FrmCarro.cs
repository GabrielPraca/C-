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
using Carro.Properties;

namespace Carro
{
    public partial class FrmCarro : Form
    {
        [DllImport("user32.dll")]
        static extern short GetKeyState(int numTecla);
        int LT_A = 65, LT_D = 68, LT_S = 83, LT_W = 87;

        [DllImport("kernel32.dll")]
        static extern uint GetTickCount();

        public static Control euOBJ;

        Veiculo[] veiculo = new Veiculo[32];
        uint FPSTick = 0, FPS = 0;

        public FrmCarro()
        {
            InitializeComponent();
            euOBJ = this;
            Random rnd = new Random();
            for (int i = 0; i < 32; i++)
                if (veiculo[i] == null)
                {
                    veiculo[i] = new Veiculo();
                    if (i != 0)
                    {
                        veiculo[i].Criar(0f + rnd.Next(0, 700), 0f + rnd.Next(0, 700));
                        veiculo[i].veloX = 10;
                        veiculo[i].veloY = 10;
                    }
                    else
                        veiculo[i].Criar(0, 0);
                    break;
                }
            TimControle.Start();
            TimFPS.Start();/*
            PictureBox ImgCarro = new PictureBox();
            ImgCarro.Parent = this;
            ImgCarro.SizeMode = PictureBoxSizeMode.AutoSize;
            ImgCarro.BringToFront();
            ImgCarro.Image = Resources.Carro0;*/
        }

        private void TimControle_Tick(object sender, EventArgs e)
        {
            try
            {
                FPS = 1000 / (GetTickCount() - FPSTick);
            }
            catch { }
            FPSTick = GetTickCount();
            if (veiculo[0] == null)
                return;
            int LT_STATUS = GetKeyState(LT_W);
            if (LT_STATUS != 0 && LT_STATUS != 1)
            {
                veiculo[0].veloY -= veiculo[0].aceleracao;
                if (veiculo[0].veloY < 0f)
                    veiculo[0].veloY *= veiculo[0].acelMultiplic;
            }
            LT_STATUS = GetKeyState(LT_S);
            if (LT_STATUS != 0 && LT_STATUS != 1)
            {
                veiculo[0].veloY += veiculo[0].aceleracao;
                if (veiculo[0].veloY > 0f)
                    veiculo[0].veloY *= veiculo[0].acelMultiplic;
            }
            LT_STATUS = GetKeyState(LT_A);
            if (LT_STATUS != 0 && LT_STATUS != 1)
            {
                veiculo[0].veloX -= veiculo[0].aceleracao;
                if (veiculo[0].veloX < 0f)
                    veiculo[0].veloX *= veiculo[0].acelMultiplic;
            }
            LT_STATUS = GetKeyState(LT_D);
            if (LT_STATUS != 0 && LT_STATUS != 1)
            {
                veiculo[0].veloX += veiculo[0].aceleracao;
                if (veiculo[0].veloX > 0f)
                    veiculo[0].veloX *= veiculo[0].acelMultiplic;
            }

            for (int i = 0; i < 32; i++)
                if (veiculo[i] != null)
                    veiculo[i].Simular();
        }

        private void TimFPS_Tick(object sender, EventArgs e)
        {
            LblFPS.Text = "FPS: " + FPS;
        }
    }

    public class Veiculo
    {
        [DllImport("kernel32.dll")]
        static extern bool Beep(int frequencia, int duracao);

        public float X = 0, Y = 0, veloX = 0, veloY = 0, aceleracao = 0.15f, acelMultiplic = 1.01f, velocidadeMaxima = 20f;
        public static int somCalc;
        Button carroOBJ;

        public void Criar(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
            carroOBJ = new Button();
            carroOBJ.Parent = FrmCarro.euOBJ;
            carroOBJ.Location = new Point(Convert.ToInt32(X), Convert.ToInt32(Y));
            carroOBJ.Size = new Size(75, 25);
            carroOBJ.Text = "CARRO";
            carroOBJ.UseVisualStyleBackColor = true;
            carroOBJ.Visible = true;
        }

        public void Simular()
        {
            if (veloX > 0f)
            {
                if (veloX > velocidadeMaxima)
                    veloX = velocidadeMaxima;
            }
            else if (veloX < 0f)
            {
                if (veloX < -velocidadeMaxima)
                    veloX = -velocidadeMaxima;
            }
            if (veloY > 0f)
            {
                if (veloY > velocidadeMaxima)
                    veloY = velocidadeMaxima;
            }
            else if (veloY < 0f)
            {
                if (veloY < -velocidadeMaxima)
                    veloY = -velocidadeMaxima;
            }

            X += veloX;
            Y += veloY;

            if (X < 0)
            {
                X = 0;
                veloX *= -1;
            }
            else if (X + carroOBJ.Width > FrmCarro.euOBJ.Width)
            {
                X = FrmCarro.euOBJ.Width - carroOBJ.Width;
                veloX *= -1;
            }
            if (Y < 0)
            {
                Y = 0;
                veloY *= -1;
            }
            else if (Y + carroOBJ.Height > FrmCarro.euOBJ.Height)
            {
                Y = FrmCarro.euOBJ.Height - carroOBJ.Height;
                veloY *= -1;
            }

            carroOBJ.Location = new Point(Convert.ToInt32(X), Convert.ToInt32(Y));

            if (veloX > 0 && veloX > 0.05f)
                veloX -= 0.05f;
            else if (veloX < 0 && veloX < -0.05f)
                veloX += 0.05f;
            else
                veloX = 0f;

            if (veloY > 0 && veloY > 0.05f)
                veloY -= 0.05f;
            else if (veloY < 0 && veloY < -0.05f)
                veloY += 0.05f;
            else
                veloY = 0f;
        }
    }
}
