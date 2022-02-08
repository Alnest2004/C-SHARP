using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (y < x && y > 0 && x < 70 && x > 0)
            {
                Console.WriteLine("ДА");
            }
            else if ((y == x && x <= 70 && y >= 0) || (x == 70 && y <= x) || (y == 0 && x <= 70 && x >= 0))
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
