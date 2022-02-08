using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = b; i > a; i--)
            {
                if (i % 2 == 0)
                {
                    c = i* i * i;
                    Console.WriteLine(c);
                }
            }

        }
    }
}
