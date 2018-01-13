using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            while (true)
            {
                Console.Clear();
                Console.Write("1 - Soma.\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao >= 1 && opcao <= 4)
                        break;
                    else
                    {
                        Console.Clear();
                        Console.Write("Opção inválida");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Opção inválida");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            int v1, v2;
            Console.Write("Digite o valor 1: ");
            while (true)
            {
                try
                {
                    v1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Digite valor numério:");
                }
            }
            Console.Clear();
            Console.Write("Digite o valor 2: ");
            while (true)
            {
                try
                {
                    v2 = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Digite valor numério:");
                }
            }
            if (opcao == 1)
            {
                Console.Write(v1 + " + " + v2 + " = " + (v1 + v2));
                Console.ReadKey();
            }
            else if (opcao == 2)
            {
                Console.Write(v1 + " - " + v2 + " = " + (v1 - v2));
                Console.ReadKey();
            }
            else if (opcao == 3)
            {
                Console.Write(v1 + " * " + v2 + " = " + (v1 * v2));
                Console.ReadKey();
            }
            else if (opcao == 4)
            {
                Console.Write(v1 + " / " + v2 + " = " + (v1 / v2));
                Console.ReadKey();
            }
        }
    }
}
