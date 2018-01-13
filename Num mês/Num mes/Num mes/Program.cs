using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Num_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            while (true)
            {
                Console.Write("Digite um número entre 1 e 12: ");
                try
                {
                    valor = int.Parse(Console.ReadLine());
                    if (valor >= 1 && valor <= 12)
                        break;
                    else
                        Console.Clear();
                }
                catch
                {
                    Console.Clear();
                }
            }
            Console.Clear();
            if(valor == 1)
                Console.Write("Janeiro");
            else if (valor == 2)
                Console.Write("Fevereiro");
            else if (valor == 3)
                Console.Write("Março");
            else if (valor == 4)
                Console.Write("Abril");
            else if (valor == 5)
                Console.Write("Maio");
            else if (valor == 6)
                Console.Write("Junho");
            else if (valor == 7)
                Console.Write("Julho");
            else if (valor == 8)
                Console.Write("Agosto");
            else if (valor == 9)
                Console.Write("Setembro");
            else if (valor == 10)
                Console.Write("Outubro");
            else if (valor == 11)
                Console.Write("Novembro");
            else if (valor == 12)
                Console.Write("Dezembro");
            Console.Write(" é mês "+valor);
            Console.ReadKey();
        }
    }
}
