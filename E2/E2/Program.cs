using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicacion que le pida al usuario un numero positivo
              y el sistema identifique si es primo o no.
             */

            int x = 0;
            int num;
            Console.Write("Digite el numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    x++;
                }
            }
            if (x != 2)
            {
                if (x < 2)
                {
                    Console.WriteLine("El numero debe ser positivo.");
                }
                else
                {
                    Console.WriteLine("No es un numero primo.");
                }
            }
            else
            {
                if (x < 2)
                {
                    Console.WriteLine("El numero debe ser positivo.");
                }
                else
                {
                    Console.WriteLine("si es un numero primo.");
                }
            }
            Console.ReadKey();
        }
    }
}
