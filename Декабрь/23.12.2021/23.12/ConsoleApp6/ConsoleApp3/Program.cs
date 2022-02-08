using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            int z = max(x, 2 * y - x) + max(5 * x + 3 * y, y);
            Console.WriteLine();
            Console.WriteLine(z);
            Console.ReadKey();
        }
        static int max(int a, int b)
        {
            if (a < b) return b;
            else if (a > b) return a;
            else return a;
        }
    }
}