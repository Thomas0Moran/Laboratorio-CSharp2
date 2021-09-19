using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triángulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---TRIÁNGULOS---");
            Console.WriteLine();

            int LADO1, LADO2, LADO3;
            string linea;

            Console.Write("Seleccione el primer lado del triángulo: ");
            linea = Console.ReadLine();
            LADO1 = Convert.ToInt16(linea);
            Console.WriteLine();

            Console.Write("Seleccione el segundo lado del triángulo: ");
            linea = Console.ReadLine();
            LADO2 = Convert.ToInt16(linea);
            Console.WriteLine();

            Console.Write("Seleccione el tercer lado del triangulo: ");
            linea = Console.ReadLine();
            LADO3 = Convert.ToInt16(linea);
            Console.WriteLine();

            if ((LADO1 == LADO2) & (LADO1 == LADO3))
            {
                Console.WriteLine("Los lados formaran un triangulo Equilatero");//lados iguales
            }
            else
            {
                if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
                {
                    Console.WriteLine("Los lados formaran un triangulo Escaleno");//lados distintos
                }
                else
                {
                    Console.WriteLine("Los lados formaran un triangulo Isóseles");//solo dos lados iguales
                }
            }

            Console.ReadKey();
        }
    }
}
