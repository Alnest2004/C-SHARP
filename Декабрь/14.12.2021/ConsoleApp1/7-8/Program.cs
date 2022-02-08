using System;

namespace _7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7-8 - трехзначное число ");
            Console.WriteLine("Введите значение  числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 100000;
            int a2 = (y % 100000) / 10000;
            int a3 = y % 10;
            int x = a * 100 + a2 * 10 + a3 ;
            
            Console.WriteLine("Ответ : х = " + x);
            Console.WriteLine("Задание 7-8 - четырехзначное  число ");
            Console.WriteLine("Введите значение четырехзначного  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 10000000;
            int b1 = (y1 % 10000000) / 1000000;
            int b2 = (y1 % 1000000) / 100000;
            int b3 = y1%10;
            int x1 = b*1000+b1*100+b2*10+b3;
            Console.WriteLine("Ответ : х = " + x1);
        }
    }
}
