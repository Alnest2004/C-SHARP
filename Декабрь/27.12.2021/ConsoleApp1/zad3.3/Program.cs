using System;

namespace zad3._3
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
            Console.Write("Ввведите заданое число B = ");
            int B = int.Parse(Console.ReadLine());
            for (int i = a+1 ; i <= b; i++)
            {
                if (Kol(i) == B)
                {
                    Console.WriteLine("Сумма четных цифр ближайшего числа " + i + ", которая равна заданному числу B =  " + Kol(i));
                    break;
                }


            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x > 0)
            {
                if (x % 10 % 2 != 0)
                {
                    s ++ ;
                }
                x /= 10;
            }
            return s;
        }
    }
}
