using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Num_Crecente
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, v3;
            Console.Write("Digite o valor 1:");
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
            Console.Write("Digite o valor 2:");
            while (true)
            {
                try
                {
                    v2 = int.Parse(Console.ReadLine());
                    if (v2 > v1)
                    {
                        int tmp = v1;
                        v1 = v2;
                        v2 = tmp;
                    }
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Digite valor numério:");
                }
            }
            Console.Write("Digite o valor 3:");
            while (true)
            {
                try
                {
                    v3 = int.Parse(Console.ReadLine());
                    if (v3 > v2)
                    {
                        int tmp = v2;
                        v2 = v3;
                        v3 = tmp;
                    }
                    if (v2 > v1)
                    {
                        int tmp = v1;
                        v1 = v2;
                        v2 = tmp;
                    }
                    break;
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Digite valor numério:");
                }
            }
            Console.Clear();
            Console.Write(v3+", "+v2+", "+v1);
            Console.ReadKey();
        }
    }
}
