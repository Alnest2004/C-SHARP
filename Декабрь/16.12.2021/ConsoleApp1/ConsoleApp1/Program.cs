using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y > x || y==Math.Abs(x) ) && y <15 )
            {
                Console.Write("Точка принадлежит");
                if (y == Math.Abs(x)) Console.Write(" и находится на границе графика функций ");
            }
            else Console.WriteLine("Точка вне границ графика ");
        }
    }
}
