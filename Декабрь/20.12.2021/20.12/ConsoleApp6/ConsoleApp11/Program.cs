using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
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
                if (i <= 5) y = Math.Pow(i, 2) + 5;
                else if (i > 5 && i < 20) y = 0;
                else y = 1;
                Console.WriteLine(y);

            }
            Console.ReadKey();
        }
    }
}