using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            if (5-x*x*x > 0)
            {
                y = Math.Sqrt(5 - x * x * x );
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
