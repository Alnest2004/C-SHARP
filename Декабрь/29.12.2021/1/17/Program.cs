using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите заданное число  = ");
            int q = Convert.ToInt32(Console.ReadLine());
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
            int k = 0;
            for (int i =1; i < a.Length; i++)
            {
                if (Math.Abs(a[i] - a[i - 1]) == q)
                    k++;
            }
            Console.WriteLine("Количество пар, между которыми разность равна заданному числу = " + k);
        }
    }
}
