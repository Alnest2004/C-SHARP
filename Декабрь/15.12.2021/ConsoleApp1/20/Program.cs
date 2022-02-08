using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x + 7 != 0 && 1 - Math.Abs(x) > 0)
            {
                y = 1 / (x + 7) + Math.Log10(1-Math.Abs(x));
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
