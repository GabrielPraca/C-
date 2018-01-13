namespace Blocos
{
    class Guindaste
    {
        public bool DirecDir { get; set; } //Direção do balanço (True = Direita / False = Esquerda)
        float _ProgBalanco; //Progresso do balanço
        public float ProgBalanco
        {
            get { return _ProgBalanco; }
            set
            {
                while (value > 1f)
                {
                    DirecDir = !DirecDir;
                    value = value - 1f;
                }

                while (value < 0f)
                {
                    DirecDir = !DirecDir;
                    value = value + 1f;
                }
                
                _ProgBalanco = value;
            }
        }
        public Andar Andar { get; set; } //Andar preso ao guindaste

        public Guindaste(bool DirecaoEsq, float ProgBalanco)
        {
            this.DirecDir = DirecDir;
            this.ProgBalanco = ProgBalanco;
        }
    }
}
