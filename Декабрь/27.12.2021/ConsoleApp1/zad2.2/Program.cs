using System;

namespace zad2._2
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
            Console.WriteLine("Числа, в которых нет нечетных цифр ");
            for (int i = a; i <= b; i++)
            {
                if ( Kol(i)==0)
                Console.WriteLine(i);

            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x > 0)
            {
                if (x % 10 % 2 != 0)
                {
                    s++;
                }
                x /= 10;
            }
            return s;
        }
    }
}
