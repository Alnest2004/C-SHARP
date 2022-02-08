using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y < 0 || y == Math.Abs(x) ) && y > -10 && y <10 && x<10 && x>-10)
            {
                Console.WriteLine("Точка принадлежит");
                if (y ==  Math.Abs(x)) Console.Write(" и находится на границе графика функций ");
            }
            else Console.WriteLine("Точка вне границ графика ");
        }
    }
}
