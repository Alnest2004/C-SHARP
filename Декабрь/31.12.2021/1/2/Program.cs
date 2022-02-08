using System;

namespace _2
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

            for (int j = 0; j < n; j++)
            {
                int min = 9;
                for (int i = 0; i < n; i++)
                {
                    if (a[i, j] < min)
                        min = a[i, j];
                }
                b[j] = min;
                Console.WriteLine();
            }
            Console.WriteLine("Новый массив из минимальных значений каждой строки : ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(b[j] + " ");

            }

        }
    }
}
