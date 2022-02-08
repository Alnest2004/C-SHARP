using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите 1-автомобиль, 2-велосипед,  3-мотоцикл, 4-самолет, 5-поезд");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Максимальная скорость-400 км/ч");
                    break;
                case 2:
                    Console.WriteLine("Максимальная скорость-295 км/ч");
                    break;
                case 3:
                    Console.WriteLine("Максимальная скорость-300 км/ч");
                    break;
                case 4:
                    Console.WriteLine("Максимальная скорость-950 км/ч");
                    break;
                case 5:
                    Console.WriteLine("Максимальная скорость-200 км/ч");
                    break;

            }
            Console.ReadKey();


        }
    }
}