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
            int max = Kol(a);
            for (int i = a; i <= b; i++)
            {
                if (Kol(i) >=max)
                {
                    max = Kol(i);

                }

            }
            for (int i = a; i <=b; i++)
            {
                if (Kol(i) == max)
                {
                    Console.WriteLine(i);

                }
            }
        }
        static int Kol(int x)
        {
            int k = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    k++;
                }
            }
            return k;
        }
    }
}
