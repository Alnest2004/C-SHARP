using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (x - 1 != 0 && 1 - 4 * x != 0)
            {
                y = 1/(x-1)+2/(1-4*x) ;
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
