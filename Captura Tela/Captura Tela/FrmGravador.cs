using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AviFile;

namespace Captura_Tela
{
    public partial class FrmGravador : Form
    {
        List<Bitmap> BufferQuadros = new List<Bitmap>();
        bool gravando = false;
        VideoStream video;
        AviPlayer player;

        public FrmGravador()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            BtnParar.Enabled = true;
            BtnGravar.Enabled = false;
            BtnReproduzir.Enabled = false;
            gravando = true;
            ImgSaida.BackColor = Color.FromArgb(30, 30, 30);

            Thread Th = new Thread(new ThreadStart(thCapturaVideo));
            Th.IsBackground = true;
            Th.Priority = ThreadPriority.BelowNormal;
            Th.Start();
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            if (gravando)
            {
                gravando = false;
                BtnParar.Enabled = false;
            }
            else
            {
                player.Stop();
                BtnParar.Enabled = false;
                BtnGravar.Enabled = true;
                BtnReproduzir.Enabled = true;
                if (ImgSaida.Image != null)
                    ImgSaida.Image.Dispose();
                ImgSaida.Image = null;
                video.Close();
                video = null;
            }
        }

        private void BtnReproduzir_Click(object sender, EventArgs e)
        {
            video = new AviManager(Application.StartupPath + "\\Vídeo.avi", true).GetVideoStream();
            player = new AviPlayer(video, ImgSaida, null);
            player.Start();
            BtnParar.Enabled = true;
            BtnGravar.Enabled = false;
            BtnReproduzir.Enabled = false;
        }

        private void thGravaVideo()
        {
            if (File.Exists(Application.StartupPath + "\\Vídeo.avi"))
                File.Delete(Application.StartupPath + "\\Vídeo.avi");

            AviManager managerAvi = new AviManager(Application.StartupPath + "\\Vídeo.avi", false);
            video = null;

            Bitmap img;

            while (gravando)
            {
                while (BufferQuadros.Count > 0)
                {
                    try
                    {
                        lock (BufferQuadros) { img = BufferQuadros[0]; }

                        if (video == null)
                            video = managerAvi.AddVideoStream(true, 10, img);
                        else
                            video.AddFrame(img);
                        img.Dispose();

                        lock (BufferQuadros)
                        {
                            BufferQuadros.RemoveAt(0);
                            Invoke((MethodInvoker)delegate { Text = "Gravador - (" + BufferQuadros.Count + " imagens no buffer)"; });
                        }
                    }
                    catch { }
                    Thread.Sleep(1);
                }
                Thread.Sleep(1);
            }
            managerAvi.Close();
            video = null;

            Invoke((MethodInvoker)delegate
            {
                BtnGravar.Enabled = true;
                BtnReproduzir.Enabled = true;
                ImgSaida.BackColor = Color.Black;
                Text = "Gravador";
            });
        }

        private void thCapturaVideo()
        {
            Size tamanhoTela = Screen.PrimaryScreen.Bounds.Size;
            Bitmap img;
            Graphics tela;

            Thread th = new Thread(new ThreadStart(thGravaVideo));
            th.IsBackground = true;
            th.Start();

            while (gravando)
            {
                img = new Bitmap(tamanhoTela.Width, tamanhoTela.Height);
                tela = Graphics.FromImage(img);
                tela.CopyFromScreen(0, 0, 0, 0, tamanhoTela);
                tela.Dispose();
                lock (BufferQuadros)
                {
                    Invoke((MethodInvoker)delegate { Text = "Gravador - (" + BufferQuadros.Count + " imagens no buffer)"; });
                    BufferQuadros.Add(img);
                }
                while (video == null) { Thread.Sleep(1); }
                Thread.Sleep(100);
            }
        }

        private void FrmGravador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (player != null)
                player.Stop();
            if (video != null)
                video.Close();
            gravando = false;
        }
    }
}
