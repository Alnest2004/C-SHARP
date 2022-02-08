using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double result;
            Console.WriteLine("Введите значение в радианах");
            num = Convert.ToDouble(Console.ReadLine());
            result = num * 57.29;
            Console.WriteLine("Градусы:" + result);
            result = num * 3437.75;
            Console.WriteLine("Минуты:" + result);
            result = num * 206264.99;
            Console.WriteLine("Секунды:" + result);
        }
    }
}
