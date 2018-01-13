using System.Drawing;

namespace Blocos
{
    class Andar
    {
        public bool Caindo { get; set; }
        public PointF Posicao { get; set; }
        public float VelX { get; set; }
        public float VelY { get; set; }
        public float Angulo { get; set; }
        public Textura Textura { get; set; }

        public Andar(PointF Posicao, float Angulo, Textura Textura)
        {
            this.Posicao = Posicao;
            this.Angulo = Angulo;
            this.Textura = Textura;
            Caindo = false;
        }

        public Andar(float x, float y, float Angulo, Textura Textura)
        {
            this.Posicao = new PointF(x, y);
            this.Angulo = Angulo;
            this.Textura = Textura;
            Caindo = false;
        }
    }
}
