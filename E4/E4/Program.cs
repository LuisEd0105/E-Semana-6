
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int alt;
            string a = "";

            while (a.ToLower() != "s")
            {
                alt = rnd.Next(50, 100);
                Console.WriteLine("El numero entre 50 y 100 es: " + alt + " \n");
                Console.WriteLine("Si desea salir presione S"
                    + "\nSi desea generar otro numero presione C");
                a = Console.ReadLine();
                
               
            }
        }
    }
}
