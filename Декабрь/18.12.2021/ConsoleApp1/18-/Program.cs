using System;

namespace _18_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 18");
            for (int i = 100; i < 1000; i++)
            {
                int a = i / 100;
                int b = i / 10 % 10;
                int c = i % 10;

                if ((a == b) || (b == c)) Console.Write("{0}{1}{2}, ", a, b, c);
            }
            Console.ReadKey();
        }
    }
}
