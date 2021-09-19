using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_de_dos_numeros
{
    class Mnumeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Mayor de dos numeros---");
            Console.WriteLine();

            int NUM1, NUM2;
            string linea;

            Console.WriteLine("Seleccione el primer numero: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.WriteLine();

            Console.WriteLine("Seleccione el segundo numero: ");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();

            if((NUM1 > NUM2))
            {
                Console.WriteLine($"El numero {NUM1} es mayor a {NUM2}");
            }
            else
            {
                if((NUM1 == NUM2))
                {
                    Console.WriteLine($"El numero {NUM1} es igual a {NUM2}");
                }
                else
                {
                    Console.WriteLine($"El numero {NUM1} es menor a {NUM2}");
                }
            }
            

            Console.ReadKey();

        }
    }
}
