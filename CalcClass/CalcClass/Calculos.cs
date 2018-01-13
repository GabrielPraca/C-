using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcClass
{
    class Calculos
    {
        public float valor1 { get; set; }
        public float valor2 { get; set; }
        public float result { get; set; }

        public float Somar()
        {
            result = valor1 + valor2;
            return result;
        }

        public void Subtrair()
        {
            result = valor1 - valor2;
        }

        public float Multiplicar(float valor1, float valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            result = valor1 * valor2;
            return result;
        }

        public void Dividir(float valor1, float valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            result = valor1 / valor2;
        }
    }
}
