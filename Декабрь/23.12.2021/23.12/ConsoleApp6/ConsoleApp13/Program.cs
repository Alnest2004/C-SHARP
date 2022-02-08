using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(f(x));
            Console.ReadKey();
        }
        static int f(int x)
        {
            if (x >= 100 && x <= 999)
            {
                int rev = 0;
                while (x > 0)
                {
                    rev = rev * 10 + x % 10;
                    x /= 10;
                }
                return rev;
            }
            else return x;
        }
    }
}