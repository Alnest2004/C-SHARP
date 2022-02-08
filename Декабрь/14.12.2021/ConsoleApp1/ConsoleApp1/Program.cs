using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 - трехзначное число ");
            Console.WriteLine("Введите значение трехзначного числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 100;
            int a1 = y % 10;
            int a2 = (y % 100) / 10;
            int x = a * 2 * 100 + a1 * 10 + a2;
            Console.WriteLine("Ответ : х = "+x);
            Console.WriteLine("Задание 2 - четырехзначное  число ");
            Console.WriteLine("Введите значение четырехзначного  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 1000;// тысячи
            int b1 = (y1 % 1000)/100; //сотни 
            int b2 = y1 % 10;//единицы
            int b3 = (y1 % 100) / 10;//десятки 
            int x1 = b * 2000  + b1 * 100 + b2 * 10 + b3;
            Console.WriteLine("Ответ : х = " + x1);

        }
    }
}
