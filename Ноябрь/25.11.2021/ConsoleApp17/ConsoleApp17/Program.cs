using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int T;
            Console.WriteLine("Введите прошедшее время в секундах:");
            T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Часов=" + T / 3600 + "Минут=" + T / 60 % 60 + "Секунд" + T % 60);
        }
    }
}
