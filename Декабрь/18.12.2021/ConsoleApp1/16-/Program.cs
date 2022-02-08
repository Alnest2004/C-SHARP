using System;

namespace _16_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 16");
            for (int i = 10; i < 100; i++)
            {
                if (Math.Abs(i % 10 - (i - i % 10) / 10) <= 2)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
