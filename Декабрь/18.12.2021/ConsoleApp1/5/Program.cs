using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y");
            int y = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            for (int i = b; i > a; i--)
            {
                if (i % 10 == x || i %10 == y )
                {
                    Console.WriteLine("Чисел, оканчивающихся на х или у :  "+i);
                }
            }
        }
    }
}
