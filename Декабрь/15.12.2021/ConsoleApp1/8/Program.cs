using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x * x + 2 * x + 1 > 0 && Math.Sqrt(x * x + 2 * x + 1) != 0)
            {
                y = (3*x+4)/Math.Sqrt(x*x+2*x+1);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
