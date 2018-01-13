using System;
using System.Drawing;

namespace Blocos
{
    class Nuvem
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Rotacao { get; set; }
        public float Velo { get; set; }
        public Point[] Fumacas { get; set; }

        public Nuvem(float x, float y, float Rotacao, float Velo, int NumFumacas)
        {
            X = x;
            Y = y;
            this.Rotacao = Rotacao;
            this.Velo = Velo;
            Fumacas = new Point[NumFumacas];
        }
    }
}