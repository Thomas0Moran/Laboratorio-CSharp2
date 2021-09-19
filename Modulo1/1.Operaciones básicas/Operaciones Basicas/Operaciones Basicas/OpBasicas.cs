using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_Basicas
{
    class OpBasicas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Operaciones basicas---");
            int NUM1, NUM2, RESUL;
            string linea;


            Console.WriteLine("Seleccione el primer numero:");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.WriteLine();

            Console.WriteLine("Seleccione el segundo numero:");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();

            RESUL = NUM1 + NUM2;
            Console.WriteLine($"La suma de {NUM1} y {NUM2} da un total de={RESUL}");

            RESUL = NUM1 - NUM2;
            Console.WriteLine($"La resta de {NUM1} y {NUM2} da un total de={RESUL}");

            RESUL = NUM1 * NUM2;
            Console.WriteLine($"La multipicación de {NUM1} y {NUM2} da un total de={RESUL}");

            RESUL = NUM1 / NUM2;
            Console.WriteLine($"La división de {NUM1} y {NUM2} da un total de={RESUL}");

            RESUL = NUM1 % NUM2;
            Console.WriteLine($"El reciduo de {NUM1} y {NUM2} da un total de={RESUL}");

            Console.ReadKey();

        }
    }
}
