using System;

namespace ConsoleApp2
{
    class Program
    {
        static int[,] Input(out int n)
        {
            Console.WriteLine("Размер массива: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {

                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        static void Vivod(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    Console.Write("{0,5} ", a[i, j]);
                }
            }
        }
        static void gg(int[,] a)
        {
            int r, r2;
            if (a.GetLength(0) % 2 == 0)
            {
                r = a.GetLength(0) / 2;
                r2 = r - 1;
            }
            else
            {
                r = a.GetLength(0) / 2;
                r2 = 0;
            }
            for (int i = 0; i < a.GetLength(1); i++)
            {
                int temp = a[r, i];
                a[r, i] = a[r2, i];
                a[r2, i] = temp;
            }
        }
        static void Main(string[] args)
        {
            int n;
            int[,] Array = Input(out n);
            Console.WriteLine("Исходный массив: ");
            Vivod(Array);
            Console.WriteLine("Входной  массив: ");
            gg(Array);
            Vivod(Array);
        }
    }
}
