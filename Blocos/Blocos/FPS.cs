using System.Collections.Generic;

namespace Blocos
{
    internal static class FPS
    {
        static int UltimoTick { get; set; }
        static int indice { get; set; }
        static float[] FPSs { get; set; }
        internal static float Media
        {
            get
            {
                float soma = 0;

                foreach (float media in FPSs)
                    soma += media;

                return soma / FPSs.Length;
            }
        }

        static FPS()
        {
            UltimoTick = -1;
            indice = 0;
            FPSs = new float[20];
        }

        internal static void Registrar(int Tick)
        {
            if (Tick != UltimoTick)
            {
                if (UltimoTick >= 0)
                {
                    FPSs[indice] = 1000f / (Tick - UltimoTick);
                    indice = (indice + 1) % FPSs.Length;
                }

                UltimoTick = Tick;
            }
        }
    }
}
