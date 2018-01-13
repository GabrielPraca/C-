using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LacoDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while(i>=0);
            Console.ReadKey();
        }
    }
}
