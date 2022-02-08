using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y<x || y == -1 * Math.Abs(x)) && y >-25 && y <=0)
            {
                Console.Write("Точка принадлежит");
                if (y == -1*Math.Abs(x)) Console.Write(" и находится на границе графика функций ");
            }
            else Console.WriteLine("Точка вне границ графика ");
        }
    }
}
