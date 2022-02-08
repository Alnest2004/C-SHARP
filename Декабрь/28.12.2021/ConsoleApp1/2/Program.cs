using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Задайте число = ");
            int m = Convert.ToInt32(Console.ReadLine());

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
                if (a[i] < m)
                    a[i] = m;
            }
            Console.WriteLine("Конечный массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
    }
}
