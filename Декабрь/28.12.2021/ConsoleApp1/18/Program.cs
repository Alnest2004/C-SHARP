using System;

namespace _18
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
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum+=  a[i, j];
                }
            }
            int k = 0;
            Console.WriteLine("Сумма элементов равна = " + sum);
            for (int i = 0; i < 3; i++)
            {
                while (sum != 0)
                {
                    sum = sum / 10;
                    k++;
                }
            }

            if (k == 2)
                Console.WriteLine("Сумма элементов является 2 значным числом  ");
            else Console.WriteLine("Сумма элементов не является 2 значным числом ");
        }
    }
}
