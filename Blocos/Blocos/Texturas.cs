using System;
using System.Drawing;
using System.Drawing.Imaging;
using Tao.OpenGl;
using System.Collections.Generic;

namespace Blocos
{
    internal static class Texturas
    {
        static List<Textura> texturas = new List<Textura>();

        internal static void LoadTextura(string Nome, string Caminho)
        {
            LoadTextura(Nome, (Bitmap)Bitmap.FromFile(Caminho));
        }

        internal static void LoadTextura(string Nome, Bitmap img)
        {
            img.RotateFlip(RotateFlipType.RotateNoneFlipY);
            BitmapData data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            Textura textura;

            int[] Id = new int[1];
            Gl.glGenTextures(1, Id);
            textura = new Textura(Nome, data.Width, data.Height, Id[0]);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textura.Id);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, data.Width, data.Height, 0, Gl.GL_BGRA, Gl.GL_UNSIGNED_BYTE, data.Scan0);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_CLAMP);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_CLAMP);

            img.UnlockBits(data);
            img.Dispose();

            texturas.Add(textura);
        }

        internal static void UnloadTextura(string Nome)
        {
            for (int i = 0; i < texturas.Count; i++)
            {
                if (texturas[i].Nome == Nome)
                {
                    Textura textura = texturas[i];

                    Gl.glDeleteTextures(1, new int[] { textura.Id });
                    texturas.Remove(textura);
                    break;
                }
            }
        }

        internal static Textura GetTextura(string Nome)
        {
            for (int i = 0; i < texturas.Count; i++)
                if (texturas[i].Nome == Nome)
                    return texturas[i];

            return null;
        }

        internal static void DrawTextura(Textura textura, float x, float y, float Width, float Height, float angulo)
        {
            if (textura == null)
                return;

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, textura.Id);

            if (angulo != 0)
            {
                Gl.glPushMatrix();
                Gl.glTranslatef(x + Width / 2, y + Height / 2, 0);
                Gl.glRotatef(angulo, 0, 0, 1);
                Gl.glTranslatef(-(x + Width / 2), -(y + Height / 2), 0);
            }

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0, 0); Gl.glVertex2f(x, y);
            Gl.glTexCoord2f(1, 0); Gl.glVertex2f(x + Width, y);
            Gl.glTexCoord2f(1, 1); Gl.glVertex2f(x + Width, y + Height);
            Gl.glTexCoord2f(0, 1); Gl.glVertex2f(x, y + Height);
            Gl.glEnd();

            if (angulo != 0)
                Gl.glPopMatrix();

            Gl.glDisable(Gl.GL_TEXTURE_2D);
        }
    }

    internal class Textura
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Textura(string Nome, int Width, int Height, int Id)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Width = Width;
            this.Height = Height;
        }
    }
}
