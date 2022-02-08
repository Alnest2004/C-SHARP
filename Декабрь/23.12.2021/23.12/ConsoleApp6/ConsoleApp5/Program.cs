using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите a");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            int y = int.Parse(Console.ReadLine());
            if (f(x) > f(y))
            {
                Console.WriteLine("В точке b");
            }
            else
            {
                Console.WriteLine("В точке a");
            }
            Console.ReadKey();
        }
        static double f(int x)
        {
            return Math.Cos(2 * x) + Math.Sin(x - 3);
        }
    }
}