using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите концы отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int y;
            for (int i = a; i <= b - 1; i++)
            {
                y = i * (i + 1);
                int rev = 0;
                while (y > 0)
                {
                    rev = (rev * 10) + (y % 10);
                    y /= 10;
                }
                if (rev == (i * (i + 1)))
                {
                    Console.WriteLine("{0} {1}", i, i + 1);
                }

            }
        }
    }
}