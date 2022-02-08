using System;

namespace _14
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
                    a[i, j] = valera.Next(0, 9);
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

            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < k1; j++)
                {
                    k += a[i, j];
                }
                b[i] = k;
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = k2+1; j <n; j++)
                {
                    k += a[i, j];
                }
                b[i] = b[i]+k;
                Console.WriteLine();
            }
            Console.WriteLine("Новый массив из cуммы элементов, не попадающих в интервал от K1 до K2: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");

            }
        }
    }
}
