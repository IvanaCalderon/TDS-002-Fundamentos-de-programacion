using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorMax = 0;
            int times = 0;
            

            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("ingrese" + "[" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());

                    if (matriz[i, j] > valorMax)
                    {
                        valorMax = matriz[i, j];
                        

                    }


                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    

                    if (matriz[i, j] == valorMax)
                    {
                        times++;


                    }


                }
            }
                Console.WriteLine($"El valor maximo {valorMax} se repite {times} veces");

                    Console.ReadKey();



            
        }
    }
}
