﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 20");
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if (y < 5 && x < 10 && y > 0 && x > 0)
            {
                Console.WriteLine("ДА");
            }
            else if (y == 5 || x == 10 || y == 0 || x == 0)
            {
                Console.WriteLine("На границе");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
            Console.ReadLine();
        }
    }
}