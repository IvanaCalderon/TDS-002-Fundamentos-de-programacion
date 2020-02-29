using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {

            int sumatoria = 0;
            int[] mayores = new int[4];
            
            
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                mayores[i] = matriz[i, 0];
                for (int j = 0; j < 4; j++)
                {   

                    Console.WriteLine("ingrese" + "[" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());

                    if(mayores[i]< matriz[i, j])
                    {
                        mayores[i] = matriz[i, j];
                    }


                }
            }

            for(int i = 0; i < 4; i++)
            {
                sumatoria = mayores[i];

            }

            sumatoria = sumatoria / 4;

            Console.WriteLine($"El promedio de la suma de los numeros mayores por cada fila es igual a {sumatoria}");


            


            Console.ReadKey();
        }
    }
}
