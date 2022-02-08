using System;

namespace _6
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
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (max != a[i])
                    Console.WriteLine("Номер элементов, не совпадающих с максимальным : "+i) ;
            }

            Console.WriteLine("Выходной массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
        }
    }
}
