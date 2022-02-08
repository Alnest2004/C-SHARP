using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            int number = 0;
            Console.Write("Введите размерность матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j1 = n - 1; j1 >= 0; j1--)
                    {
                        arr[i, j1] = ++number;
                    }

                }
                else
                {
                    for (int j2 = 0; j2 < n; j2++)
                    {
                        arr[i, j2] = ++number;
                    }
                }
            }

            for (int i = 0; i < n; i++, Console.WriteLine())
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + " ");
            Console.ReadKey(); 
        }
    }
}
