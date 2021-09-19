using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar_conFOR
{
    class Tabla
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Tabla de multiplicar (con for)---");
            Console.WriteLine();

            int NUM, I, RESUL;
            string linea;

            Console.WriteLine("Seleccione el numero que desea multiplicar: ");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            Console.WriteLine("");

            for(I = 1; I <= 12; I++)
            {
                RESUL = NUM * I;
                Console.WriteLine($"{NUM} * {I} = {RESUL}");
            }
            Console.WriteLine("Presione una tecla para cerrar.");
            Console.ReadKey();

        }
    }
}
