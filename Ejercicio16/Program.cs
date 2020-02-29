using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            int[,] matriz = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("ingrese" + "[" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());




                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {


                    if (matriz[i, j] < 10)
                    {
                        times++;


                    }


                }
            }

            Console.WriteLine($"En la matriz existen {times} numeros de un solo digito");


            Console.ReadKey();
        }
    }
}
