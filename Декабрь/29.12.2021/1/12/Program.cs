using System;

namespace _12
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
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            int k1 = 0;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == max)
                {
                    k = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] == min)
                {
                    k1 = i;
                    break;
                }
            }
            int sum = 0;
            if (k1 < k)
            {
                Console.WriteLine("Первым встречается минимальный элемент");
                for (int i = k1; i <= k; i++)
                {
                    sum += a[i];
                   
                }
            }
            if (k < k1)
            {
                Console.WriteLine("Первым встречается максимальный элемент");
                for (int i = k; i <= k1; i++)
                {

                    sum += a[i];
                }
            }
            Console.WriteLine("Сумма элементов " + sum);
        }
    }
}
