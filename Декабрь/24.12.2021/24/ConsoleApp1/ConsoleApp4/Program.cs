using System;

namespace ConsoleApp4
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
                i++;
                if (Kol(a)==Kol(i))
                {
                    Console.WriteLine(i);
                    break;
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
