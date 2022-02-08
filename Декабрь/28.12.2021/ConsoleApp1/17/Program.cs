using System;

namespace _17
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
            int pr = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pr = pr * a[i, j];
                }
            }
            int k = 0;
            Console.WriteLine("Произведение элементов равно = " + pr);
            for (int i = 0; i < 3; i++)
            {
                while (pr != 0)
                {
                    pr = pr / 10;
                    k++;
                }
            }
           
            if (k == 3)
                Console.WriteLine("Произведение является 3 значным числом  ");
            else Console.WriteLine("Произведение не является 3 значным числом ");
        }
    }
}
