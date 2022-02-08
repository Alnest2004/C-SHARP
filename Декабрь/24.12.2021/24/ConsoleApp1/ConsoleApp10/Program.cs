using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите концы отрезка");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            int c = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (Kol(i) == c)
                {
                    Console.WriteLine($"{i}");

                }

            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x > 0)
            {
                s += x % 10;
                x /= 10;
            }
            return s;
        }
    }
}
