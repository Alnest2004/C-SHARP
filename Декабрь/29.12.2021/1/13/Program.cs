using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Размер массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите " + i + "-й элемент массива : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Исходный массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
            Console.WriteLine();
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == min)
                {
                    k = i;
                    break;
                }
            }
            int m = 0;
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            
            for (int i = n - 1; i > 0; i--)
            {
                if (a[i] == max)
                {
                    m = i;
                    break;
                }
            }
            int s = 0;
            s = a[k];
            a[k] = a[m];
            a[m] = s;
            Console.WriteLine("Выходной массив : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");

            }
        }
    }
}
