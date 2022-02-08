﻿using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите " + i + "-й элемент массива : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Исходный массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            int k = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[i - 1])
                    k++;
            }
            Console.WriteLine("Количество пар, где предыдущий элемент меньше предыдущего = " + k);
        }
    }
}
