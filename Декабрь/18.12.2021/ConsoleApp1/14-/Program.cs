using System;

namespace _14_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            for (int a = 10; a <= 99; a++)
            {
                if (((a / 10) + (a % 10)) % 2 == 0) Console.WriteLine(a);
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
