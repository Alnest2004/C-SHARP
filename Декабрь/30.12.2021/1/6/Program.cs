using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 5;
            int m = 5;
            int[,] mass = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = rnd.Next(9);
                }
            }
            Console.WriteLine("Исходный массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    int x = mass[i, j];
                    mass[i, j] = mass[i, (m - 1) - j];
                    mass[i, (m - 1) - j] = x;
                }
            }
            Console.WriteLine("Выходной массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mass[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
}
