using System;

namespace _6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите А:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                int g = i % 10;
                if (g % 2 == 0) Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }
    }
    }
}
