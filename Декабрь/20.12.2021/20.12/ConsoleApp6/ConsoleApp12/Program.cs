using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите диапозон значений");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг h");
            int h = int.Parse(Console.ReadLine());
            double y = 0;
            for (double i = a; i <= b; i += h)
            {
                if (i < 0) y = 0;
                else if (i >= 0 && i != 1) y = Math.Pow(i, 2) + 1;
                else y = 1;
                Console.WriteLine(y);

            }
            Console.ReadKey();
        }
    }
}