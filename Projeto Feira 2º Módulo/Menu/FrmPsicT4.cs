using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class FrmPsicT4 : Form
    {
        string Arrastando = "";
        int[] mousePosRelativ = new int[2];

        public FrmPsicT4()
        {
            InitializeComponent();
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
            ImgEncaixes.SizeMode = PictureBoxSizeMode.AutoSize;
            ImgQuadrado.Parent = ImgEncaixes;
            ImgCirculo.Parent = ImgEncaixes;
            ImgHexagono.Parent = ImgEncaixes;
            ImgTriangulo.Parent = ImgEncaixes;
        }

        private void FrmPsicT4_SizeChanged(object sender, EventArgs e)
        {
            BtnProx.Location = new Point(this.Width - BtnProx.Width - 12, this.Height - BtnProx.Height - 12);
            BtnSair.Location = new Point(this.Width - BtnSair.Width - 12, 12);
            LblTempo.Location = new Point(12, 12);
            ImgEncaixes.Location = new Point(this.Width / 2 - ImgEncaixes.Width / 2, this.Height / 2 - ImgEncaixes.Height / 2);
            LblInformacao.Location = new Point(this.Width / 2 - LblInformacao.Width / 2, ImgEncaixes.Location.Y / 2 - LblInformacao.Height / 2);
        }

        private void TimAtualizarTempo_Tick(object sender, EventArgs e)
        {
            LblTempo.Text = String.Format("Fim da Prova: {0:00}:{1:00}", (FrmMenu.tempoCount / 60), (FrmMenu.tempoCount % 60));
            if (FrmMenu.tempoCount <= 0)
            {
                FrmMenu.FrmMain.Show();
                Dispose();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que deseja desistir de tirar carta de motorista?", "Atensão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FrmMenu.FrmMain.PararTeste();
                FrmMenu.FrmMain.Show();
                Dispose();
            }
        }

        private void FrmPsicT4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void VerificaFim()
        {
            if (!ImgCirculo.Visible && !ImgHexagono.Visible && !ImgQuadrado.Visible && !ImgTriangulo.Visible)
                TimFim.Start();
        }

        private void ImgCirculo_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosRelativ[0] = e.X + 1;
            mousePosRelativ[1] = e.Y + 1;
            Arrastando = "circulo";
            TimMouseArrasto.Start();
        }

        private void ImgQuadrado_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosRelativ[0] = e.X + 1;
            mousePosRelativ[1] = e.Y + 1;
            Arrastando = "quadrado";
            TimMouseArrasto.Start();
        }

        private void ImgTriangulo_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosRelativ[0] = e.X + 1;
            mousePosRelativ[1] = e.Y + 1;
            Arrastando = "triângulo";
            TimMouseArrasto.Start();
        }

        private void ImgHexagono_MouseDown(object sender, MouseEventArgs e)
        {
            mousePosRelativ[0] = e.X + 1;
            mousePosRelativ[1] = e.Y + 1;
            Arrastando = "hexágono";
            TimMouseArrasto.Start();
        }

        private void TimMouseArrasto_Tick(object sender, EventArgs e)
        {
            if (Arrastando == "circulo")
            {
                int MouseX = MousePosition.X - ImgEncaixes.Location.X - mousePosRelativ[0],
                    MouseY = MousePosition.Y - ImgEncaixes.Location.Y - mousePosRelativ[1];
                if (MouseX < 0)
                    MouseX = 0;
                else if (MouseX > ImgEncaixes.Width - ImgCirculo.Width)
                    MouseX = ImgEncaixes.Width - ImgCirculo.Width;
                if (MouseY < 0)
                    MouseY = 0;
                else if (MouseY > ImgEncaixes.Height - ImgCirculo.Height)
                    MouseY = ImgEncaixes.Height - ImgCirculo.Height;
                ImgCirculo.Location = new Point(MouseX, MouseY);
            }
            else if (Arrastando == "quadrado")
            {
                int MouseX = MousePosition.X - ImgEncaixes.Location.X - mousePosRelativ[0],
                    MouseY = MousePosition.Y - ImgEncaixes.Location.Y - mousePosRelativ[1];
                if (MouseX < 0)
                    MouseX = 0;
                else if (MouseX > ImgEncaixes.Width - ImgQuadrado.Width)
                    MouseX = ImgEncaixes.Width - ImgQuadrado.Width;
                if (MouseY < 0)
                    MouseY = 0;
                else if (MouseY > ImgEncaixes.Height - ImgQuadrado.Height)
                    MouseY = ImgEncaixes.Height - ImgQuadrado.Height;
                ImgQuadrado.Location = new Point(MouseX, MouseY);
            }
            else if (Arrastando == "triângulo")
            {
                int MouseX = MousePosition.X - ImgEncaixes.Location.X - mousePosRelativ[0],
                    MouseY = MousePosition.Y - ImgEncaixes.Location.Y - mousePosRelativ[1];
                if (MouseX < 0)
                    MouseX = 0;
                else if (MouseX > ImgEncaixes.Width - ImgTriangulo.Width)
                    MouseX = ImgEncaixes.Width - ImgTriangulo.Width;
                if (MouseY < 0)
                    MouseY = 0;
                else if (MouseY > ImgEncaixes.Height - ImgTriangulo.Height)
                    MouseY = ImgEncaixes.Height - ImgTriangulo.Height;
                ImgTriangulo.Location = new Point(MouseX, MouseY);
            }
            else if (Arrastando == "hexágono")
            {
                int MouseX = MousePosition.X - ImgEncaixes.Location.X - mousePosRelativ[0],
                    MouseY = MousePosition.Y - ImgEncaixes.Location.Y - mousePosRelativ[1];
                if (MouseX < 0)
                    MouseX = 0;
                else if (MouseX > ImgEncaixes.Width - ImgHexagono.Width)
                    MouseX = ImgEncaixes.Width - ImgHexagono.Width;
                if (MouseY < 0)
                    MouseY = 0;
                else if (MouseY > ImgEncaixes.Height - ImgHexagono.Height)
                    MouseY = ImgEncaixes.Height - ImgHexagono.Height;
                ImgHexagono.Location = new Point(MouseX, MouseY);
            }
        }

        private void ImgCirculo_MouseUp(object sender, MouseEventArgs e)
        {
            if (Arrastando == "circulo")
            {
                TimMouseArrasto.Stop();
                if (Math.Abs(ImgCirculo.Location.X - 424) <= 2 && Math.Abs(ImgCirculo.Location.Y - 461) <= 2)
                    ImgCirculo.Hide();
            }
            VerificaFim();
        }

        private void ImgQuadrado_MouseUp(object sender, MouseEventArgs e)
        {
            if (Arrastando == "quadrado")
            {
                TimMouseArrasto.Stop();
                if (Math.Abs(ImgQuadrado.Location.X - 249) <= 2 && Math.Abs(ImgQuadrado.Location.Y - 461) <= 2)
                    ImgQuadrado.Hide();
            }
            VerificaFim();
        }

        private void ImgTriangulo_MouseUp(object sender, MouseEventArgs e)
        {
            if (Arrastando == "triângulo")
            {
                TimMouseArrasto.Stop();
                if (Math.Abs(ImgTriangulo.Location.X - 101) <= 2 && Math.Abs(ImgTriangulo.Location.Y - 405) <= 2)
                    ImgTriangulo.Hide();
            }
            VerificaFim();
        }

        private void ImgHexagono_MouseUp(object sender, MouseEventArgs e)
        {
            if (Arrastando == "hexágono")
            {
                TimMouseArrasto.Stop();
                if (Math.Abs(ImgHexagono.Location.X - 561) <= 2 && Math.Abs(ImgHexagono.Location.Y - 413) <= 2)
                    ImgHexagono.Hide();
            }
            VerificaFim();
        }

        private void TimFim_Tick(object sender, EventArgs e)
        {
            FrmPsicT1.acertos++;
            BtnProx.PerformClick();
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            FrmPsicT5 inst = new FrmPsicT5();
            inst.Show();
            Dispose();
        }
    }
}