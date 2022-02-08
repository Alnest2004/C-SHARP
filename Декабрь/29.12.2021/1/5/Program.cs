using System;

namespace _5
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
            int max = a[0];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (max > a[i])
                {
                    max = a[i];
                    k = i;
                }
            }
            int m = a[0];
            a[0] = a[k];
            a[k] = m;
           

            Console.WriteLine("Выходной массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
        }
    }
}
