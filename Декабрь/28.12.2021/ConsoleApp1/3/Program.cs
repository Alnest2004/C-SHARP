﻿using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Задайте начало интервала a = ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте конец интервала b = ");
            int b = Convert.ToInt32(Console.ReadLine());
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
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= a1 && a[i]<=b  )
                    a[i] = 0 ;
            }
            Console.WriteLine("Конечный массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
