using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a,b,x");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                double y = (a + b * Math.Sin(Math.Pow(x, 3) - 4)) / (1 + Math.Pow(x, 2));
                Console.WriteLine("y={0}", y);

            }
            catch
            {
                Console.WriteLine("Ошибка: Неверный формат числа");
            }

        }
    }
}