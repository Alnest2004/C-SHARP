using System;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 18");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((x > y && x < 7 && y != 0) || (x < y && x > -7 && y != 0))
            {
                Console.WriteLine("ДА");
            }
            else if ((x == y && x <= 7) || (x == y && x >= -7) || (y == 0 && Math.Abs(x) <= 7))
            {
                Console.WriteLine("На границе");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
            Console.ReadLine();
        }
    }
}