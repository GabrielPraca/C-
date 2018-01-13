using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

using NAudio.Midi;


namespace BeepMIDI
{
    public partial class FrmMain : Form
    {
        [DllImport("kernel32.dll")]
        static extern void Beep(ushort Freq, ushort Tempo);

        MidiFile midiFile;
        Thread Reproducao;
        double[] Notas = new double[109];
        BufferedGraphics Buffer;
        Graphics G;

        public FrmMain()
        {
            InitializeComponent();
            GerarNotas();
            Buffer = BufferedGraphicsManager.Current.Allocate(PnlNotas.CreateGraphics(), PnlNotas.DisplayRectangle);
            G = Buffer.Graphics;
            DrawNota(-1);
        }

        void GerarNotas()
        {
            double mult = Math.Pow(2, 1d / 12d);
            for (int i = 21; i <= 108; i++)
                Notas[i] = (i > 21 ? Notas[i - 1] * mult : 27.5);
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (FdOpen.ShowDialog() == DialogResult.OK)
                midiFile = new MidiFile(FdOpen.FileName);
        }

        void DrawNota(int Nota)
        {
            int w = PnlNotas.Width, h = PnlNotas.Height,
                Y, X;
            G.Clear(Color.DarkSlateGray);

            for (int y = 0; y < 3; y++)
            {
                Y = (int)(y * (h / 3f));
                G.DrawLine(Pens.Teal, 0, Y, w, Y);
                for (int x = 0; x < 29; x++)
                {
                    X = (int)(x * (w / 29f));
                    G.DrawLine(Pens.Teal, X, 0, X, h);
                }
            }
            G.DrawLine(Pens.Teal, w - 1, 0, w - 1, h - 1);
            G.DrawLine(Pens.Teal, 0, h - 1, w - 1, h - 1);
            if (Nota >= 0)
            {
                X = (int)((Nota % 30) * (w / 29f));
                Y = (int)((Nota / 29) * (h / 3f));
                G.FillRectangle(Brushes.DarkTurquoise, X, Y, (w / 29f), (h / 3f));
            }

            try
            {
                Invoke((MethodInvoker)delegate { Buffer.Render(); });
            }
            catch { };
        }

        void Reproduzir(object velocidade)
        {
            Invoke((MethodInvoker)delegate { Text = "Beep MIDI - Processando..."; });
            try
            {
                if (midiFile != null)
                {
                    IList<MidiEvent> midiEvents = midiFile.Events.GetTrackEvents((int)NumFaixa.Value);
                    List<ushort[]> msgs = new List<ushort[]>();
                    float velo = (float)velocidade / 5f;
                    long UltimoTick = -1;

                    foreach (MidiEvent evento in midiEvents)
                    {
                        try
                        {
                            NoteOnEvent noe = (NoteOnEvent)evento;
                            ushort[] msg = new ushort[3];
                            if (UltimoTick < noe.AbsoluteTime || UltimoTick == -1)
                            {
                                msg[0] = (ushort)noe.NoteNumber;
                                msg[1] = (ushort)(noe.NoteLength);
                                if (msgs.Count > 0)
                                    msgs[msgs.Count - 1][2] = (ushort)((noe.AbsoluteTime - UltimoTick) - msgs[msgs.Count - 1][1]);
                                UltimoTick = noe.AbsoluteTime;
                            }

                            msgs.Add(msg);
                        }
                        catch { }
                    }

                    //Reproduz a música
                    Invoke((MethodInvoker)delegate { Text = "Beep MIDI - Reproduzindo..."; });
                    foreach (ushort[] msg in msgs)
                    {
                        DrawNota(msg[0] - 20);
                        Beep((ushort)(Notas[msg[0]]), (ushort)(msg[1] / velo));
                        DrawNota(-1);
                        Thread.Sleep((ushort)(msg[2] / velo));
                    }
                }
            }
            catch { }

            Invoke((MethodInvoker)delegate
            {
                Reproducao = null;
                BtnPlay.Texto = "Reproduzir";
                Text = "Beep MIDI";
                DrawNota(-1);
            });
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (Reproducao == null)
            {
                Reproducao = new Thread(new ParameterizedThreadStart(Reproduzir));
                Reproducao.IsBackground = true;
                Reproducao.Start((float)BarVeloc.Value);
                BtnPlay.Texto = "Parar";
            }
            else
            {
                Reproducao.Abort();
                Reproducao = null;
                BtnPlay.Texto = "Reproduzir";
                Text = "Beep MIDI";
                DrawNota(-1);
            }
        }

        private void PnlNotas_Paint(object sender, PaintEventArgs e)
        {
            try { Buffer.Render(); }
            catch { }
        }
    }
}
