using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {


            int[,] matriz = new int[4, 3];
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("ingrese" + "[" + i + "," + j + "]");
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());




                }
            }

           int sum1 = matriz[0, 0] + matriz[0, 1] + matriz[0, 2];
           int sum2 = matriz[1, 0] + matriz[1, 1] + matriz[1, 2];
           int sum3 = matriz[2, 0] + matriz[2, 1] + matriz[2, 2];
           int sum4 = matriz[3, 0] + matriz[3, 1] + matriz[3, 2];

            Console.WriteLine($"Suma de elementos de la fila 0: {sum1}");
            Console.WriteLine($"Suma de elementos de la fila 1: {sum2}");
            Console.WriteLine($"Suma de elementos de la fila 2: {sum3}");
            Console.WriteLine($"Suma de elementos de la fila 3: {sum4}");



            Console.ReadKey();
        }
    }
}
