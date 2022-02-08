using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            int i = a;
            while (true)
            {
                i--;
                if (Kol(a) == Kol(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static int Kol(int x)
        {
            int s = 0;
            while (x > 0)
            {
                s += x % 10;
                x /= 10;
            }
            return s;
        }
    }
}
