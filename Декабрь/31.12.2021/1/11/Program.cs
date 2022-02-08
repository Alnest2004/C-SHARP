using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
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

            for (int i = 0; i < n; i++)
            {
                int k = -1;
                for (int j = 0; j < n ; j++)
                {
                    if (a[i, j] < 0 )
                    {
                        k = j;
                        break;
                    }
                    
                }
                b[i] = k;
                Console.WriteLine();
                if (b[i] == -1)
                    Console.WriteLine("В строке " + i + " нет отрицательных элементов ");
            }
            Console.WriteLine("Новый массив из номеров первых отрицательных элементов каждой строки   : ");
            for (int i = 0; i < n; i++)
            {
                if (b[i]!=-1)
                Console.Write(b[i] + " ");

            }
        }
    }
}
