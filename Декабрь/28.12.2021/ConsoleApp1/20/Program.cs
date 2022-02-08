using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива ");
            Console.WriteLine("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            Console.WriteLine("Введите массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Исходный массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Элементы с нечетными индексами");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i,j]>0 && i %2 ==0 && j %2 ==0 || i == 0 && j == 0 && a[i, j] > 0)
                    {
                        Console.WriteLine(a[i, j]);

                    }
                }

            }
        }
    }
}
