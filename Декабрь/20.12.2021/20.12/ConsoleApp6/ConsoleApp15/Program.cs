using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.WriteLine("Введите диапозон значений");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг h");
            int h = int.Parse(Console.ReadLine());
            double y = 0;
            for (int i = a; i <= b; i += h)
            {
                if ((i - 1) < 0) y = 1;
                else if ((i - 1) == 1) y = 0;
                else y = -1;
                Console.WriteLine(y);

            }
            Console.ReadKey();
        }
    }
}