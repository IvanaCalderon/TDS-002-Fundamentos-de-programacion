using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 4];
            for (int B = 0; B < 4; B++)
            {
                for (int C = 0; C < 4; C++)
                {
                    Console.WriteLine("ingrese" + "[" + B + "," + C + "]");
                    A[B, C] = Convert.ToInt16(Console.ReadLine());

                    if (B == 1 && C == 1)
                    {
                        Console.Clear();
                        for (B = 0; B < 2; B++)
                        {
                            for (C = 0; C < 2; C++)
                            {
                                Console.Write(A[B, C]);
                            }
                            Console.WriteLine();

                        }
                    }
                }

            }

            Console.ReadKey();



            int[] miarreglo = new int[10];
            int valorMax = miarreglo[0];
            int posicion = -1;

            Console.WriteLine("Escribe 10 numeros");

            for (int i = 0; i < miarreglo.Length; i++)
            {
                miarreglo[i] = Convert.ToInt16(Console.ReadLine());
            }



            for (int i = 0; i < miarreglo.Length; i++)
            {
                if (isPrime(miarreglo[i]))
                {
                    if (miarreglo[i] > valorMax || !isPrime(valorMax))
                    {
                        valorMax = miarreglo[i];
                        posicion = i;
                    }
                }
            }
            if (posicion == -1)
            {
                Console.WriteLine("No existen numeros primos en el listado");
            }
            else
            {
                Console.WriteLine($"El numero primo mayor se encuentra en la posicion {posicion}");
            }

            Console.ReadKey();
        }

        static int[] numerosPrimos = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        static bool isPrime(int numero)
        {
            for (int i = 0; i < numerosPrimos.Length; i++)
            {
                if (numero == numerosPrimos[i])
                    return true;
            }
            return false;

        }
    }
}
