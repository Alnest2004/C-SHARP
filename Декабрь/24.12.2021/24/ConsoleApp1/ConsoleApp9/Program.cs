using System;

namespace ConsoleApp9
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
                Console.Write($"{i} - ");
                Console.WriteLine(Kol(i));
            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x>0)
            {
                s += x % 10;
                x /= 10;
            }
            return s;
        }
    }
}
