using System;

namespace ConsoleApp6
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
                    Console.Write($"{i}");

                }

            }
        }
        static int Kol(int x)
        {
            int k = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    k+=i;
                }
            }
            return k;
        }
    }
}
