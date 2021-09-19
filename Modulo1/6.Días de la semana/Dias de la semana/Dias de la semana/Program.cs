using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Dias de la semana---");
            Console.WriteLine();

            int num;
            string linea;

            Console.Write("Ingrese un numero del 1 al 7 a continuación: ");
            linea = Console.ReadLine();
            num = Convert.ToInt32(linea);
            Console.WriteLine();

            switch (num)
            {
                case 1:
                    Console.WriteLine("El dia seleccionado es el LUNES");
                    break;

                case 2:
                    Console.WriteLine("El dia seleccionado es el MARTES");
                    break;

                case 3:
                    Console.WriteLine("El dia seleccionado es el MIERCOLES");
                    break;

                case 4:
                    Console.WriteLine("El dia seleccionado es el JUEVES");
                    break;

                case 5:
                    Console.WriteLine("El dia seleccionado es el VIERNES");
                    break;

                case 6:
                    Console.WriteLine("El dia seleccionado es el SABADO");
                    break;

                case 7:
                    Console.WriteLine("El dia seleccionado es el DOMINGO");
                    break;

                default:
                    Console.WriteLine($"No existe un dia con el que se identifique el numero {num}");
                    break;
            }
            Console.ReadKey();

        }
    }
}
