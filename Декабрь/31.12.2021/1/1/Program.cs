using System;

namespace _1
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

            for(int i = 0; i <n; i++)
            {
                for ( int j =0; j <n ; j++)
                {
                    a[i, j] = valera.Next(1,9);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n ; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < n; i++)
            {
                int max = 0;
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    max = a[i, j];
                }
                b[i] = max;
                Console.WriteLine();
            }
            Console.WriteLine("Новый массив из максимальных значений каждой строки : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
               
            }

        }
    }
}
