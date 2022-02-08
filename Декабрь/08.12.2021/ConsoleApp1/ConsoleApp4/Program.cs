﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.Write("Введите размерность матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(1, 20);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int mini = 0;

            int minj = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] < arr[mini, minj])
                    {
                        mini = i;
                        minj = j;
                    }
                }
                Console.WriteLine();
            }
            int s = 0;
            for (int j = 0; j < n; j++)
            {
                s = s + arr[mini, j];
            }
            Console.WriteLine("Сумма = " + s);




            Console.ReadKey();
        }
    }
}
