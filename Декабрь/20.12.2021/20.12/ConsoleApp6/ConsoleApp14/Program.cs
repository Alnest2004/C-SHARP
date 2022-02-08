using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
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
                if (i < 0) y = 0.2 * Math.Pow(i, 2) - i - 0.1;
                else if (i > 0 && i != 0.1) y = Math.Pow(i, 2) / (i - 0.1);
                else if (i == 0.1) y = 0;
                Console.WriteLine(y);

            }
            Console.ReadKey();
        }
    }
}