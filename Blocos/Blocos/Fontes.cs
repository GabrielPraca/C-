using System;
using System.Drawing;
using System.Drawing.Text;
using System.Collections.Generic;
using System.IO;
using Tao.OpenGl;

namespace Blocos
{
    internal static class Fontes
    {
        static List<Fonte> fontes = new List<Fonte>();

        public static void LoadFonteFromFile(string Nome, string Caminho, float Tamanho)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Caminho);

            LoadFonte(Nome, new Font(pfc.Families[0], Tamanho));

            pfc.Dispose();
        }

        public static void LoadFonte(string Nome, string Fonte, float Tamanho)
        {
            LoadFonte(Nome, new Font(Fonte, Tamanho));
        }

        public static void LoadFonte(string Nome, Font fonteWindows)
        {
            Fonte fonteGl = new Fonte(Nome);
            int TextWH;
            Bitmap img = new Bitmap(1, 1);
            Graphics G = Graphics.FromImage(img);
            SizeF tmpSize;

            //Obtem o tamanho de cada caractere
            tmpSize = G.MeasureString("A", fonteWindows, int.MaxValue, StringFormat.GenericDefault);
            fonteGl.Height = (int)tmpSize.Height;
            TextWH = (int)(tmpSize.Height * 16);

            for (char i = (char)0; i < (char)0xFF; i++)
            {
                tmpSize = G.MeasureString(i.ToString(), fonteWindows, int.MaxValue, StringFormat.GenericDefault);
                fonteGl.WidthD[i] = tmpSize.Width;

                tmpSize = G.MeasureString(i.ToString(), fonteWindows, int.MaxValue, StringFormat.GenericTypographic);
                fonteGl.WidthT[i] = tmpSize.Width;
                if (fonteGl.WidthT[i] <= 0)
                    fonteGl.WidthT[i] = fonteGl.WidthD[i];

                int iX = i % 16,
                    iY = i / 16;

                fonteGl.TexCoord[i] = new RectangleF((fonteGl.Height * iX + fonteGl.Height / 2 - fonteGl.WidthD[i] / 2) / TextWH,
                                                     1f - (fonteGl.Height * (iY + 1)) / TextWH,
                                                     (fonteGl.Height * iX + fonteGl.Height / 2 + fonteGl.WidthD[i] / 2) / TextWH,
                                                     1f - (fonteGl.Height * iY) / TextWH);
            }

            //Gera a imagem com os caracteres
            G.Dispose();
            img.Dispose();
            img = new Bitmap(TextWH, TextWH);
            G = Graphics.FromImage(img);
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            for (char i = (char)0; i < (char)0xFF; i++)
            {
                int iX = i % 16,
                    iY = i / 16;

                G.DrawString(i.ToString(), fonteWindows, Brushes.White, fonteGl.TexCoord[i].X * TextWH, (int)fonteGl.Height * iY);
            }
            //img.Save(System.Windows.Forms.Application.StartupPath + @"\" + fonteWindows.FontFamily.Name + ", " + fonteWindows.Height + ".bmp");

            Texturas.LoadTextura("FONTE: " + Nome, img);
            fonteGl.textura = Texturas.GetTextura("FONTE: " + Nome);

            G.Dispose();
            fonteWindows.Dispose();

            fontes.Add(fonteGl);
        }

        public static void DisposeFonte(string Nome)
        {
            Fonte fonte = GetFonte(Nome);

            Texturas.UnloadTextura(fonte.textura.Nome);
            fontes.Remove(fonte);
        }

        public static Fonte GetFonte(string Nome)
        {
            foreach (Fonte fonte in fontes)
            {
                if (fonte.Nome == Nome)
                    return fonte;
            }

            return null;
        }

        static void DrawCaractere(char Carac, Fonte fonteGl, float x, float y)
        {
            RectangleF TexCoord = fonteGl.TexCoord[Carac];
            float w = fonteGl.WidthD[Carac], h = fonteGl.Height;
            x = x - w / 2;

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(TexCoord.X, TexCoord.Y); Gl.glVertex2f(x, y);
            Gl.glTexCoord2f(TexCoord.Width, TexCoord.Y); Gl.glVertex2f(x + w, y);
            Gl.glTexCoord2f(TexCoord.Width, TexCoord.Height); Gl.glVertex2f(x + w, y + fonteGl.Height);
            Gl.glTexCoord2f(TexCoord.X, TexCoord.Height); Gl.glVertex2f(x, y + fonteGl.Height);
            Gl.glEnd();
        }

        public static void DrawString(string Texto, Fonte fonteGl, Color cor, bool Sombra, float x, float y)
        {
            if (fonteGl == null)
                return;
            if (Sombra)
                DrawString(Texto, fonteGl, Color.FromArgb(cor.A, Color.Black), false, x + 1, y - 1);

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, fonteGl.textura.Id);
            Gl.glColor4ub(cor.R, cor.G, cor.B, cor.A);

            float offset = 0;
            for (int i = 0; i < Texto.Length; i++)
            {
                if (i == 0)
                    offset += fonteGl.WidthD[Texto[i]];
                else
                    offset += fonteGl.WidthT[Texto[i]];

                DrawCaractere(Texto[i], fonteGl, x + (int)(offset - fonteGl.WidthD[Texto[i]] / 2), y);
            }

            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }
    }

    internal class Fonte
    {
        public string Nome { get; set; }
        public float[] WidthD { get; set; }
        public float[] WidthT { get; set; }
        public RectangleF[] TexCoord { get; set; }
        public float Height { get; set; }
        public Textura textura { get; set; }

        public Fonte(string Nome)
        {
            this.Nome = Nome;
            this.WidthD = new float[256];
            this.WidthT = new float[256];
            this.TexCoord = new RectangleF[256];
        }

        public SizeF MedirTexto(string Texto)
        {
            SizeF Size = new SizeF(0, Height);

            for (int i = 0; i < Texto.Length; i++)
            {
                if (i == 0 || i == Texto.Length - 1)
                    Size.Width += WidthD[Texto[i]];
                else
                    Size.Width += WidthT[Texto[i]];
            }

            return Size;
        }
    }
}
