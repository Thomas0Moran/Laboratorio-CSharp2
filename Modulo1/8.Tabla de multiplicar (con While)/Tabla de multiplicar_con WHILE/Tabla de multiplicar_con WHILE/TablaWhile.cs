using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar_con_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Tabla de multiplicar con WHILE---");
            Console.WriteLine();

            int NUM, I, RESUL;
            string linea;

            Console.Write("Seleccione el numero que desea multiplicar: ");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            Console.WriteLine();

            I = 1;
            while((I <= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine($"{NUM} * {I} = {RESUL}");
                I = I + 1;
            }
            Console.WriteLine("Presione cualquier tecla para cerrar.");

            Console.ReadKey();
        }
    }
}
