﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
            if ((x<0)&&(((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) > 3) && (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) < 8))
            {
                Console.WriteLine("Точка попала в заштрихованную область");
            }
            else if ((x <= 0) && (((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) == 3) || (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))) == 8))
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
