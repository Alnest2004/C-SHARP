using System;

namespace zad2._1
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

                Console.WriteLine("В числе " + i + " количество нечетных цифр равно " + Kol(i));

            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x > 0)
            {
                if (x % 10 % 2 != 0)
                {
                    s ++;
                }
                x /= 10;
            }
            return s;
        }
    }
}
