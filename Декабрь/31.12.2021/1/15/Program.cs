using System;

namespace _15
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
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    k += a[i, j];
                }
                b[i] = k;
                Console.WriteLine();
            }

            Console.WriteLine("Новый массив из суммы элементов каждой строки : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Наибольший элемент нового массива  : ");
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (b[i] > max)
                    max = b[i];
            }
            Console.WriteLine(max);
        }
    }
}
