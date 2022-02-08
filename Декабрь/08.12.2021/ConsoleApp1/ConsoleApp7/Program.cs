using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите столбцы матрицы M = ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строки матрицы N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[N, M];
            Random rnd = new Random();


            for (int i = 0; i < N; i++)
            {
                int min = 10;

                for (int j = 0; j < M; j++)
                {

                    mas[i, j] = rnd.Next(1, 10);
                    if ((i % 2 == 0) && (mas[i, j] <= min))
                    {
                        min = mas[i, j];
                    }
                    Console.Write(mas[i, j] + " \t");
                }
                if (i % 2 == 0)
                {
                    Console.Write(" Минимальный элемент = " + min);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            

        }
    }
}
