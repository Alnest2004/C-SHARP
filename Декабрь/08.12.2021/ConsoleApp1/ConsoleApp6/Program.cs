using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите столбцы матрицы M = ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строки матрицы N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[M, N];
            Random rnd = new Random();
            Console.WriteLine("Введите число с которым нужно искать равенство = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число на которое нужно умножить = ");
            int d = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mas[i, j] = rnd.Next(1, 10);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Строки в которых есть число " + c);
            int k = 0;

            for (int i = 0; i < M; i++)
            {
                bool pr = false;
                int j = 0;
                while (j < N && !pr)
                {
                    if (mas[i, j] == c)
                    {
                        pr = true;
                    }
                    else
                    {
                        j = j + 1;
                    }
                    if (pr)
                    {
                        k = 1;
                        Console.Write(i + " ");
                        for (j = 0; j < N; j++)
                        {
                            mas[i, j] = mas[i, j] * d;

                        }
                    }
                }
            }

            Console.WriteLine("Изменённая матрица = ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
