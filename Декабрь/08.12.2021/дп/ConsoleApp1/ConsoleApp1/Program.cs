using System;
//создать матрицу + найти наибольший элемент и перенести его на главную диагональ, первое задание (:
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы");
            Console.Write("G=");
            int g = int.Parse(Console.ReadLine());
            Console.Write("H=");
            int h = int.Parse(Console.ReadLine());
            int[,] k = new int[g, h];
            Random rnd = new Random();
            Console.WriteLine();
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    k[i, j] = rnd.Next(1, 10);
                    Console.Write(k[i,j]+ " ");
                }
                Console.WriteLine();
            }
            int imax = 0, jmax = 0;
            for (int i = 0; i < g; i++)
            {
                int max = k[i, 0];
                for (int j = 0; j < h; j++)
                {
                    if (k[i, j] > max) { max = k[i, j]; imax = i; jmax = j; }
                }
                int z = k[imax, jmax];
                k[imax, jmax] = k[i, i];
                k[i, i] = z;
                imax = i + 1; jmax = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Преобразованная матрица: ");
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(k[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}













