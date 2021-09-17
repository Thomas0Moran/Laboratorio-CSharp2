using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2
{
    class Laboratorio1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio1:");
            Console.WriteLine("-Compra de restaurant-");
            Console.WriteLine();

            byte CantBebida, CantHamburguesa, CantPapas;
            double Apagar;
            string linea;
            const double PrecioB = 1.5;
            const double PrecioH = 3;
            const double PrecioP = 2;

            Console.WriteLine("Seleccione la cantidad de Hmburguesas que desea: "); linea = Console.ReadLine();
            CantHamburguesa = byte.Parse(linea);

            Console.WriteLine("Seleccione la cantidad de Papas que desea: "); linea = Console.ReadLine();
            CantPapas = byte.Parse(linea);

            Console.WriteLine("Seleccione la cantidad de Bebidas que desea: "); linea = Console.ReadLine();
            CantBebida = byte.Parse(linea);

            Apagar = (CantHamburguesa * PrecioH) + (CantPapas * PrecioP) + (CantBebida * PrecioB);

            Console.WriteLine("El valor a pagar es: " + Apagar);
            Console.WriteLine("Pulse cualquier tecla para finalizar");
            Console.ReadKey();

        }
    }
}
