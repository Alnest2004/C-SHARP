using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите z");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите v");
            int v = int.Parse(Console.ReadLine());
            int t = min(min(x, y), min(v, z));
            Console.WriteLine();
            Console.WriteLine(t);
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