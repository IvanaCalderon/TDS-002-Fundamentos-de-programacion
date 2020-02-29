using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("ingrese" + "[" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());




                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                    if (matriz[i, j] % 10 == 0 || matriz[i,j] == 0)
                    {
                        Console.WriteLine($"Existe un numero terminado en 0  en la posicion [{i},{j}]");


                    }


                }
            }


            Console.ReadKey();
        }
    }
}
