using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            if (2*x-1 > 0 && Math.Sqrt(2*x-1)!=0)
            {
                y = x/Math.Sqrt(2*x-1);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
