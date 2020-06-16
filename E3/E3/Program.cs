using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num;
            decimal x = 10;
            decimal cont = 1;

            Console.Write("Digite el numero del cual quiera saber su cantidad de cifras: ");
            num = decimal.Parse(Console.ReadLine());

                while (x <= num)
                {
                    cont++;
                    x = x * 10;
                }
                Console.WriteLine("Tiene " + cont + " digitos.");
            Console.ReadKey();
        }
    }
}
