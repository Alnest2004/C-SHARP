using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (y > x && y < 0 && x > -23 && x < 0)
            {
                Console.WriteLine("ДА");
            }
            else if ((y == x && x >= -23 && y <= 0) || (x == -23 && y >= x) || (y == 0 && x >= -23 && x <= 0))
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