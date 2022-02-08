using System;

namespace _16
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
            for (int j = 0; j < n; j++)
            {
                int k = 1;
                for (int i = 0; i < n; i++)
                {
                    k = k*a[i, j];
                }
                b[j] = k;
                Console.WriteLine();
            }

            Console.WriteLine("Новый массив из произведения элементов каждой строки : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Наименьший элемент нового массива  : ");
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                if (b[i] <  min)
                    min = b[i];
            }
            Console.WriteLine(min);
        }
    }
}
