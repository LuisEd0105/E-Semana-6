using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            while (a <= 100)
            {
                if (a % 10 == 0)
                {
                    b++;
                }
                a++;
            }
            Console.WriteLine("Entre los numeros del 1 al 100 se encuentran " + b + " ceros.");
            Console.ReadKey();
        }
    }
}
