using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x * x * x - 1 >= 0 && Math.Sqrt(x * x - 1) !=  0 && x * x - 1 > 0)
            {
                y = Math.Sqrt(x * x *x -1 ) / Math.Sqrt(x*x-1);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
