using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for (int ii = 1; ii <= 10; ii++)
                    Console.WriteLine(ii+"x"+i+" = "+ii*i);
               Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
