using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if ((x*x*x*x-1) > 0 && 1+x > 0)
            {
                y = Math.Log10(x * x * x * x - 1)*Math.Log10(1 + x);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
