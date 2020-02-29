using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            int[,] matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("ingrese" + "[" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());




                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {


                    if (matriz[i, j] % 5 == 0)
                    {
                        times++;


                    }


                }
            }

            Console.WriteLine($"En la matriz existen {times} numeros multiplos de 5");


            Console.ReadKey();
        }
    }
}
