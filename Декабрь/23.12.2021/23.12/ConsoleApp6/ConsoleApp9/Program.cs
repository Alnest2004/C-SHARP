using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(f(x,2)+f(x,4)+f(x,6));
            Console.ReadKey();
        }
        static double f(int x, int n)
        {
            double rez = Math.Pow(x, n) / n;
            return rez;
        }
    }
}