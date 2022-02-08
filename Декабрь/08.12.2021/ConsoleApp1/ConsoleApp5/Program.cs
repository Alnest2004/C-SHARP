using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            Console.WriteLine("Введите столбцы матрицы M = ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строки матрицы N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[N, K];
            Console.WriteLine("Введите количество элементов в мтарице A[N,K]");
            Random rnd = new Random();
            int[] mas2 = new int[K];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write("A[" + i + "," + j + "]=");
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите " + K + " элементов массива D для сравнения со строками матрицы");
            for (int i = 0; i < K; i++)
            {
                Console.Write("D[" + i + "]=");
                mas2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Матрица A");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Массив D");
            for (int i = 0; i < K; i++)
            {
                Console.Write(mas2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Номера строк A совпадающих с массивом D");
            int s = 0;
            for (int i = 0; i < N; i++)
            {
                int j = 0;
                while (j < K && mas[i, j] == mas2[j])
                {
                    j++;
                }
                if (j == K)
                {
                    s = 1;
                    Console.Write(i);
                }
            }


            Console.ReadKey();
        }
    }
}
