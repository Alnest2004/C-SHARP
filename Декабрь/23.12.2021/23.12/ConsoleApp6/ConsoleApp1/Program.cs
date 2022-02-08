using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            int z = min(3 * x, 2 * y) + min(x - y, x + y);
            Console.WriteLine();
            Console.WriteLine(z);
            Console.ReadKey();
        }
        static int min(int a, int b)
        {
            if (a < b) return a;
            else if (a > b) return b;
            else return a;
        }
    }
}