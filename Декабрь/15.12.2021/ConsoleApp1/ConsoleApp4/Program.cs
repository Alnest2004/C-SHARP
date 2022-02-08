using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            if ((x-1) > 0)
            {
                y = Math.Log10(x - 1);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
        }
    }
}
