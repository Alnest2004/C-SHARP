using System;

namespace _10
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
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++)
            {
                int k = 0;
                for (int i = n - 1; i >= 0; i--)

                {
                    if (a[i, j] % 2 != 0 && a[i, j] != 0)
                    {
                        k = i;
                        break;
                    }
                }
                b[j] = k;
                Console.WriteLine();
                if (b[j] == 0)
                {
                    Console.WriteLine("В столбце № " + j + " нет нечетных элементов");
                }
            }
            Console.WriteLine("Новый массив из номеров последних нечетных элементов каждого столбца  : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");

            }
        }
    }
}
