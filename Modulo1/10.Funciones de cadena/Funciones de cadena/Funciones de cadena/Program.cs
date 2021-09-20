using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_de_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Funciones de cadena---");
            Console.WriteLine();

            string NOM;
            byte K;

            Console.WriteLine("Digite su nombre a continuación: ");
            NOM = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Longitud: {NOM.Length}");
            Console.WriteLine($"¿Usted es el diseñador de todo esto?: {NOM.Contains("Thomas")}");
            Console.WriteLine($"Remplazo la vocal A: {NOM.Replace("a", ("e"))}");
            Console.WriteLine($"En minusculas: {NOM.ToLower()}");
            Console.WriteLine($"En mayusculas: {NOM.ToUpper()}");
            Console.WriteLine($"Removiendo cuatro letras: {NOM.Remove(4)}");
            Console.WriteLine($"Extraccion de cuatro letras: {NOM.Substring(4)}");
            Console.WriteLine($"Cuatro letras hacia la izquierda: {Left(NOM, 4)}");
            Console.WriteLine($"Cuatro letras hacia la derecha: {Right(NOM, 4)}");
            Console.WriteLine();

            Console.Write("Presione cualquier tecla: ");
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Desde la derecha: ");
            for (K = 1; K <= NOM.Length; K++)
            {
                Console.WriteLine(Right(NOM, K));
            }
            Console.WriteLine();

            Console.WriteLine("Presione cualquier tecla para cerrar.");
            Console.ReadKey();

            

        }

        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(0, length);
            return result;
        }

    }
}
