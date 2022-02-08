using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число D ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма делителей числа N, кратных числам :  " + c + " или " + d);
            int sum = 0;
            for (int i = 1; i < n+1 ; i++)
            {
                if (n % i == 0)
                {
                    if (i % c == 0 ||  i % d == 0)
                    {
                        sum += i;
                        
                    }

                }
            }
            Console.WriteLine(sum);
        }
    }
}
