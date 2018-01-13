using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.Write("Digite um número:");
            while (true)
            {
                try
                {
                    valor = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Digite valor numério:");
                }
            }
            Console.Clear();
            if (valor > 10)
                Console.Write("É maior que 10.");
            else if(valor == 10)
                    Console.Write("É igual a 10.");
                else
                    Console.Write("É menor que 10.");
            Console.ReadKey();
        }
    }
}
