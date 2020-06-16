using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una aplicacion que muestre la tabla de multiplicar del 7//

            int x = 0;
            int y = 7;
            int z = 0;

            Console.WriteLine("La tabla del 7\n");
            while (x <= 12)
            {
                Console.WriteLine(+ y + " x " + (z++) + " = " + (x * y));
                x++;
            }
            Console.ReadKey();
        }
    }
}
