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
                if (max > a[i])
                    max = a[i];
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (max == a[i])
                    Console.WriteLine("Номер минамального элемента : " + i);

            }
            
        }
    }
}
