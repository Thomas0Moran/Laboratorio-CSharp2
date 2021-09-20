using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Numeros primos---");
            Console.WriteLine();

            int n, x, resi, sw;
            string linea;
            x = 2;
            sw = 0;

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            n = Convert.ToInt32(linea);
            Console.WriteLine();
            while(x < n && sw == 0)
            {
                resi = n % x;
                if(resi == 0)
                {
                    sw = 1;
                }
                else
                {
                    x = x + 1;
                }
            }
            if(sw == 0)
            {
                Console.WriteLine($"El numero {n} es primo");
            }
            else
            {
                Console.WriteLine($"El numero {n} no es primo");
            }

            Console.ReadKey();

        }
    }
}
