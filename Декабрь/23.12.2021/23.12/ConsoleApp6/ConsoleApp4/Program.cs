using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите a");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int y = int.Parse(Console.ReadLine());
            if (f(x) > f(y))
            {
                Console.WriteLine("В точке a");
            }
            else
            {
                Console.WriteLine("В точке b");
            }
            Console.ReadKey();
        }
        static double f(int x)
        {
            return Math.Pow(x, 3) - Math.Sin(x);
        }
    }
}