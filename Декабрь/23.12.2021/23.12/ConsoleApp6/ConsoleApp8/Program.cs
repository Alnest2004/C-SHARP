using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            double z = f(6) / 2 + f(13) / 2 + f(21) / 2;
            Console.WriteLine();
            Console.WriteLine(z);
            Console.ReadKey();
        }
        static double f(int n)
        {
            return Math.Sqrt(n) + n;
        }
    }
}
