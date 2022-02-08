using System;

namespace _3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите А:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите X:");
            int X = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                if (i % 10 == X) Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }
    }
}
