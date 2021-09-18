using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class OPbasicas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----OPERACIONES ARITMETICAS BASICAS-----");
            int NUM1, NUM2, NUM3, RESUL;
            string linea;
            
            Console.WriteLine("Seleccione el primer numero: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.WriteLine();

            Console.WriteLine("Seleccione el segundo numero:");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();
            
            RESUL = NUM1 + NUM2;
            Console.WriteLine($"La suma es: {RESUL}");
            RESUL = NUM1 - NUM2;
            Console.WriteLine($"La resta es: {RESUL}");
            RESUL = NUM1 * NUM2;
            Console.WriteLine($"La multiplicación es: {RESUL}");
            RESUL = NUM1 / NUM2;
            Console.WriteLine($"La división es: {RESUL}");
            RESUL = NUM1 % NUM2;
            Console.WriteLine($"La residuo es: {RESUL}");
            Console.ReadKey();

        }
    }
}
