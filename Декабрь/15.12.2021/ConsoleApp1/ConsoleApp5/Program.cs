using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if ((x * x - 2 * x + 1) >= 0 && 4 - 2 * x > 0)
            {
                y = Math.Sqrt(x*x - 2*x+1) / Math.Log10(4-2*x);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
