using System;

namespace _10_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите А:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                if ((i % 3 == 0) && (i % 2 == 0)) Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }
    }
}
