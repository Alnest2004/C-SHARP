using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((x>y)&&((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) < 12))
            {
                Console.WriteLine("Точка попала в заштрихованную область");
            }
            else if ((x == y) &&((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) <= 12) || ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) == 12))
            {
                Console.WriteLine("Точка на границе заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не попала в заштрихованную область");
            }
            Console.ReadKey();
        }
    }
}
