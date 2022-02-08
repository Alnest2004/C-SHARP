using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите возраст человека");
            double y = double.Parse(Console.ReadLine());
            if (y < 1) Console.WriteLine("");
            else if (y >= 1 && y <= 11) Console.WriteLine("младенец");
            else if (y > 11 && y <= 15) Console.WriteLine("ребенок");
            else if (y > 15 && y <= 25) Console.WriteLine("подросток");
            else if (y > 25 && y <= 70) Console.WriteLine("мужчина");
            else Console.WriteLine("пожилой человек");
            Console.ReadKey();


        }
    }
}
