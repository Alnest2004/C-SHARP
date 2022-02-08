using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Введите величину обьёма A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Терабайт=" + A / Math.Pow(2, 40) + " Гигабайт=" + A / Math.Pow(2, 30) + " Мегабайт=" + A / Math.Pow(2, 20) + " Килобайт=" + A / Math.Pow(2, 10));
        }
    }
}
