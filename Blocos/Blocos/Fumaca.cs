using System;
using System.Drawing;

namespace Blocos
{
    class Fumaca
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Rotacao { get; set; }
        public float Vida { get; set; }

        public Fumaca(float x, float y, float Rotacao)
        {
            X = x;
            Y = y;
            this.Rotacao = Rotacao;
            this.Vida = 0;
        }
    }
}