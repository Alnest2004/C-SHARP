using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) < 15) || (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) > 25)
            {
                Console.WriteLine("Точка попала в заштрихованную область");
            }
            else if (((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) == 15) || (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) == 25)
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
