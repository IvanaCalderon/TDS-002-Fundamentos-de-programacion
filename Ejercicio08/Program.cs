using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
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


                    if (matriz[i, j] % 10 == 0 || matriz[i, j] == 0)
                    {
                        
                        times++;



                    }


                }
            }
            Console.WriteLine($"En la matriz existen {times} numeros terminados en 0");

            Console.ReadKey();
        }
    }
}
