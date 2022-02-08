using System;

namespace _1
{
    class Program
    {
        static void F(double x)
        {

            if (x % 5 == 0)
                x = x / 5;
            else x = x + 1;
            Console.WriteLine("х = " + x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите х = ");
            double x = Convert.ToInt32(Console.ReadLine());
            F(x);
            Console.ReadKey();
        }
    }
}
