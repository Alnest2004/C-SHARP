using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((((y < 0) && ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) < 12))) || (x>y)&&(x>0)&&(y>0) && ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) < 12))
            {
                Console.WriteLine("Точка попала в заштрихованную область");
            }
            else if ((((y <= 0) && ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) <= 12))) || (x >= y) && (x > 0) && (y > 0) && ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) <= 12))
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
