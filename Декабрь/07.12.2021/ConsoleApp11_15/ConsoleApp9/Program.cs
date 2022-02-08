using System;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int razmer = int.Parse(Console.ReadLine());
            int min = 999; int poz = 0;
            Random no = new Random();
            Console.Write("Исходный массив - ");
            int[] nemassiv = new int[razmer];
            for (int i = 0; i < nemassiv.Length; i++)

            {

                nemassiv[i] = no.Next(0, 10);
                Console.Write(nemassiv[i] + " ");
            }

            for (int i = 0; i < nemassiv.Length; i++)
            {
                if (min > nemassiv[i])
                {
                    min = nemassiv[i];
                    poz = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < nemassiv.Length; i++)
            {
                if ((i < poz) && (nemassiv[i] != min))
                {
                    Console.Write(nemassiv[i] + " ");
                }

            }
            for (int i = 0; i < nemassiv.Length; i++)
            {
                if ((i > poz) && (nemassiv[i] != min))
                {
                    Console.Write(nemassiv[i] + " ");
                }

            }
            Console.ReadKey();

        }
    }
}