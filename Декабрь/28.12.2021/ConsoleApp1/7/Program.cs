using System;

namespace _7
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
            double sum = 0;
            double sr = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            { if (a[i] < 0)
                {
                    sum += a[i];
                    k++;
                }
            }
            sr = sum / k;
            Console.WriteLine("Среднее арифметическое массива  = " + sr);
        }
    }
}
