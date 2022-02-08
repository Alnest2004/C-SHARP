using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма делителей числа " + n + ": ");
            int sum = 0;
            for (int i = 1; i < n+1; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    
                }
            }
            Console.WriteLine(sum);
        }
    }
}
