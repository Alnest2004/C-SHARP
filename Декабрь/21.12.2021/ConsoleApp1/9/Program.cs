using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 3 || n == 2 || (n % 2 != 0 && n % 3 != 0))
                Console.WriteLine("Число простое");
            else
            {
                Console.WriteLine("Число не простое");
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
