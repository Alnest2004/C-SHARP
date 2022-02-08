using System;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 16");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (y < -Math.Abs(x) && y > -100 && y < 0)
            {
                Console.WriteLine("ДА");
            }
            else if ((y == -Math.Abs(x) && y >= -100 && y <= 0) || (y == -100 && Math.Abs(x) <= 100))
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
