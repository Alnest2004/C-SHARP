using System;

namespace _13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" четырехзначное число ");
            Console.WriteLine("Введите значение  числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 1000;
            int a1 = (y % 1000) / 100;
            int a2 = (y % 100) / 10;
            int a3 = y % 10;
            int x = a3 * 1000 + a2 * 100 + a1 * 10 + a;

            Console.WriteLine("Ответ : х = " + x);
            Console.WriteLine(" пятизначное  число ");
            Console.WriteLine("Введите значение  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 10000;// 1
            int b1 = (y1 % 10000) / 1000; //2
            int b2 = (y1 % 1000) / 100; //3
            int b3 = (y1 % 100) / 10; ;//4
            int b4 = y1 % 10;//5
            int x1 = b4 * 10000 + b3 * 1000 + b2 * 100 + b1 * 10 + b;

            Console.WriteLine("Ответ : х = " + x1);
        }
    }
}
