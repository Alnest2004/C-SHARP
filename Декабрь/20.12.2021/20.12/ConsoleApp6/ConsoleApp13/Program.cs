using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
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
                if (i == 1 || i == -1) y = 1;
                else if (i >= 0 && i != 1) y = (double)(-1 / (1 - i));
                else if (i <= 0 && i != -1) y = (double)(1 / (1 + i));
                Console.WriteLine((double)y);

            }
            Console.ReadKey();
        }
    }
}