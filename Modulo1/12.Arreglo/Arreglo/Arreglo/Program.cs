using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Arreglo-----");
            Console.WriteLine();

            string[] VECTOR = { "LORENA", "ESTEBAN", "ARIEL" };
            byte K;

            for (K = 0; K <= 2; K++)
            {
                Console.WriteLine(VECTOR[K]);
            }

            Console.WriteLine("--------------------------------");

            int[] MILISTA = null;
            MILISTA = new int[] { 15, 20, 30, 10, 50, 60, 10, 150, 69 };

            for (K = 0; K <= MILISTA.Length - 1; K++)
            {
                Console.WriteLine(MILISTA[K]);
            }
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla...");



            Console.ReadKey();


        }
    }
}
