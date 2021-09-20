using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_N_números
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Suma de N numeros---");
            Console.WriteLine();

            byte CAN, K;
            int NUM;
            int SUM = 0;
            string linea;

            Console.WriteLine("Limite de numeros a sumar: ");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);

            for (K = 1; K <= CAN; K++)
            {
                Console.WriteLine("Digite un numero: ");
                linea = Console.ReadLine();
                NUM = Convert.ToInt32(linea);
                SUM += CAN;
            }
            Console.WriteLine();

            Console.WriteLine($"La suma da un total de {SUM}");
            Console.WriteLine($"La media aritmetica da un total de {SUM / CAN}");
            Console.WriteLine("");
            Console.ReadKey();



        }
    }
}
