using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---DIAS DE LA SEMANA---");
            Console.WriteLine("Ejercicio2:");
            Console.WriteLine();

            int num;
            string linea;

            Console.WriteLine("Ingrese un numero del 1 al 7 para indicarle el dia");
            linea = Console.ReadLine();

            num = int.Parse(linea);

            switch(num)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Lunes");
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Martes");
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Miercoles");
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Jueves");
                    break;

                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Viernes");
                    break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Sabado");
                    break;

                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al dia Domingo");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso esta fuera de rango");
                    break;
            }

            Console.ReadKey();

        }
    }
}
