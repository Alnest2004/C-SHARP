using System;

namespace ConsoleApp1
{
    class Program
    {
        static void F(double x)
        {


            if (x % 2 != 0)
                x = 0;
            if (x % 2 == 0)
                x = x / 2;
            Console.WriteLine("х = " + x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите х = ");
            double x = Convert.ToInt32(Console.ReadLine());
            F(x);
            Console.ReadKey();
        }
    }
}

