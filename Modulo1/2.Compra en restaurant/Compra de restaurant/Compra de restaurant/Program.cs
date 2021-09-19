using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_de_restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Compra de restaurant---");
            Console.WriteLine();
            byte CantHamburguesa, CantPapas, CantGaseosa;
            double Apagar;
            string linea;

            const double PrecioH = 2;
            const double PrecioP = 1;
            const double PrecioG = 1.5;

            Console.WriteLine($"Cantidad de Hamburguesas: ");
            linea = Console.ReadLine();
            CantHamburguesa = byte.Parse(linea);
            Console.WriteLine();

            Console.WriteLine("Cantidad de Papas: ");
            linea = Console.ReadLine();
            CantPapas = byte.Parse(linea);

            Console.WriteLine("Cantidad de Gaseosas: ");
            linea = Console.ReadLine();
            CantGaseosa = byte.Parse(linea);

            Apagar = (CantHamburguesa * PrecioH) + (CantPapas * PrecioP) + (CantGaseosa * PrecioG);
            Console.WriteLine($"Cantidad a pagar: {Apagar}$");
            Console.ReadKey();


        }
    }
}
