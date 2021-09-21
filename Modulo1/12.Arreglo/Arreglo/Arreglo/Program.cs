using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Arreglos----");
            Console.WriteLine("A)");

            string[] VECTOR = { "THOMAS", "DAI", "DANIEL" };
            string linea;
            byte K;

            for (K = 0; K <= 2; )
            {
                Console.WriteLine(VECTOR[K]);
            }
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("B)");
            int[] MILISTA = null;
            MILISTA = new int[] {15, 20, 30, 10, 50, 60, 10, 150, 69};
            for (K = 0; K <= MILISTA.Length - 1; K++)
            {
                Console.WriteLine(MILISTA[K]);
            }
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("----Ejercicos varios 1-3---- ");
            
            int[] LosValores = new int[4];
            LosValores[0] = 154;
            LosValores[1] = 10;
            LosValores[2] = -1864;
            LosValores[3] = 0;

            for(int i = 0; i < LosValores.Length; i++)
            {
                Console.WriteLine(LosValores[i]);
            }

            Console.WriteLine("----Ejercicos varios 2-3---- ");
            int[] Test = new int[6];
            Test[0] = 1;
            Test[1] = 2;
            Test[2] = 3;
            Test[3] = 4;
            Test[4] = 5;
            Test[5] = 6;
            for(int F = 0; F < Test.Length; F++)
            {
                Console.WriteLine(Test[F]);
            }

            Console.WriteLine("----Ejercicos varios 3-3---- ");
            Console.WriteLine();
            string[] Cosas = { "TIJERA", "PIEDRA", "PAPEL", };
            string Line;
            int B;

            Console.WriteLine("Oprima cualquier tecla para ver el contenido: ");
            Line = Console.ReadLine();
            B = int.Parse(Line);

            for( B = 0; B <=2; B++)
            {
                Console.WriteLine(Cosas[B]);
            }
            Console.WriteLine();



            Console.ReadKey();


        }
    }
}
