using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (3 * x != 0 && 2 * x * x * x * x * x - 1 > 0)
            {
                y = Math.Log10(Math.Abs(3*x)) / Math.Sqrt(2*x*x*x*x*x-1);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
