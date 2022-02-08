using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = 0;
            double y = 0;
            try
            {
                 x = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Неверный формат");
            }
            if ((1 + x) != 0)
            {
                y = 1 / Math.Pow((1 + x), 2);
                y = Math.Round(y, 2);
                Console.WriteLine(y);
            }
            else Console.WriteLine("функция не определена");
            
        }
    }
}
 