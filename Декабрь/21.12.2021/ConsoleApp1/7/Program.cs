using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое делителей числа N: ");
            int sum = 0;
            int sr = 0;
            int k =0;
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    k++;
                }
            }
            Console.WriteLine(sum/k);
        }
    }
}
