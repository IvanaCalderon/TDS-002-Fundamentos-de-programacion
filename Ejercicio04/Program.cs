using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[3, 4];
            for (int i = 0; i < 3; i++)
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


                    if (2) 
                    {
                        Console.WriteLine($"Existe un numero par en la posicion [{i},{j}]");


                    }


                }
            }


            Console.ReadKey();


        }
    } }
 