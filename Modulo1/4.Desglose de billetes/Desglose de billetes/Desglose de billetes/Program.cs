using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desglose_de_billetes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Desglose de billetes---");
            Console.WriteLine();
            int CAN, C100, C50, C20, C10, C5;
            C100 = 0;
            C50 = 0;
            C20 = 0;
            C10 = 0;
            C5 = 0;
            string linea;

            Console.Write("Seleccione la cantidad de dinero: ");
            linea = Console.ReadLine();
            CAN = int.Parse(linea);

            //if ((CAN >= 100))
            //{
            //    C100 = (CAN / 100);
            //    CAN = CAN - (C100 * 100);
            //}
            //if ((CAN >= 50))
            //{
            //    C50 = (CAN / 50);
            //    CAN = CAN - (C50 * 50);
            //}
            //if((CAN >= 20))
            //{
            //    C20 = (CAN / 20);
            //    CAN = CAN - (C20 * 20);
            //}
            //if((CAN >= 10))
            //{
            //    C10 = (CAN / 10);
            //    CAN = CAN - (C10 * 10);
            //}
            if((CAN >= 5))
            {
                C5 = (CAN / 5);
                CAN = C5 - (C5 * 5); 
            }

            Console.WriteLine($"La cantidad de billetes de a 100: {C100}");
            Console.WriteLine($"La cantidad de billetes de a 50: {C50}");
            Console.WriteLine($"La cantidad de billetes de a 20: {C20}");
            Console.WriteLine($"La cantidad de billetes de a 10: {C10}");
            Console.WriteLine($"La cantidad de billetes de a 5: {C5}");

            Console.ReadKey();
            
        }
    }
}
