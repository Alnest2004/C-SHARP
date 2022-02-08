using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 17");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (y > -x && y < 23 && y > 0 && x < 0)
            {
                Console.WriteLine("ДА");
            }
            else if ((y == -x && y <= 23 && y >= 0) || (y == 23 && y >= -x) || (x == 0 && y <= 23 && y >= 0))
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