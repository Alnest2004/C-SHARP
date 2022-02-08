using System;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] nemassiv = new int[10];
            Random r = new Random();
            for (int i = 0; i < nemassiv.Length; i++)
                nemassiv[i] = r.Next(0, 10);
            Console.Write("Массив:");
            for (int i = 0; i < nemassiv.Length; i++)
                Console.Write(" " + nemassiv[i]);
            Console.WriteLine();

            Console.Write("Введите некоторое число t: ");
            int kvadrat = int.Parse(Console.ReadLine());

            for (int i = 0; i < nemassiv.Length; i++)
            {
                if (Math.Pow(nemassiv[i], 2) == kvadrat)
                {
                    Console.WriteLine($"Число {nemassiv[i]} является квадратом числа {kvadrat}.");
                }
            }
            Console.ReadKey();

        }
    }
}