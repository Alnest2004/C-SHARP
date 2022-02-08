using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс К1= ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс К2 = ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            int[] b = new int[n];
            Console.WriteLine("Исходный массив : ");
            Random valera = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = valera.Next(-9, 9);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++)
            {
                int k = 1;
                for (int i = k1; i <= k2 ; i++)
                {
                    k = k* a[i, j];
                }
                b[j] = k;
                Console.WriteLine();
            }
            Console.WriteLine("Новый массив из произведения элементов с индексами от К1 до К2 : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");

            }
        }
    }
}
