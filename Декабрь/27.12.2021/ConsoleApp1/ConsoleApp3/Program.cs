using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите концы отрезка");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (Kol(i) != 0 && Kol(i) == 2 || Kol(i) != 0 && Kol(i) == 3 || Kol(i) != 0 && Kol(i) % 3 != 0 && Kol(i) % 2 != 0) 
                {
                    Console.WriteLine("Сумма четных цифр числа " + i + ", которая является простым числом :  " + Kol(i));
                }


            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x > 0)
            {
                if (x % 10 % 2 == 0)
                {
                    s += x % 10;
                }
                x /= 10;
            }
            return s;
        }
    }
}
