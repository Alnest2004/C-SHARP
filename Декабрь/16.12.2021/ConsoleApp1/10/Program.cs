using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y > 0 && x > 0) && y == -x || (y < x && x > 0) || (y > x && x < 0) && y > -10 && y < 10 && x < 10 && x > -10)
            {
                Console.WriteLine("Точка принадлежит");
                if (y == -x) Console.Write(" и находится на границе графика функций ");
            }
            else Console.WriteLine("Точка вне границ графика ");
        }
    }
}
