using System;

namespace EjerciciosMatrices
{
    class Program
    /// Leer  una matriz 4x4 entera y determinar en qué fila y en qué columna se encuentra el número mayor. 
    {
        static void Main(string[] args)
        {

            int valorMax = 0;
            int fila = 0;
            int columna = 0;

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
                        fila = i;
                        columna = j;

                    }


                }



            }

            Console.WriteLine($"El valor maximo {valorMax} esta ubicado en la fila {fila} columna {columna}");

            Console.ReadKey();


            /*
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.WriteLine("Digita" + " [" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt32(Console.Read());

                }

            }
            
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                   
                    if (matriz[i, j] > valorMax)
                    {

                        matriz[i, j] = valorMax;
                        fila = i;
                        columna = j;

                    }
            }

            Console.WriteLine($"El mayor numero {valorMax} se encuentra en la fila {fila} y en la columna {columna}");
            */
        }
    }
}
