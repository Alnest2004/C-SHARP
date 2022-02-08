using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 5-6 - трехзначное число ");
            Console.WriteLine("Введите значение трехзначного числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 100;
            int a1 = y % 10;
            int a2 = (y % 100) / 10;
            int x = a2 ;
            Console.WriteLine("Ответ : х = " + x);
            Console.WriteLine("Задание 5-6 - четырехзначное  число ");
            Console.WriteLine("Введите значение четырехзначного  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 1000;// тысячи
            int b1 = (y1 % 1000) / 100; //сотни 
            int b2 = y1 % 10;//единицы
            int b3 = (y1 % 100) / 10;//десятки 
            int x1 = b1*10+b3;
            Console.WriteLine("Ответ : х = " + x1);
        }
    }
}
