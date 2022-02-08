using System;

namespace zad3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n и m ");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Наименьшее общее кратное двух заданных чисел = "+ Kol(n,m));
            
           
        }
        static int Kol(int n, int m)
        {
            int min = 100;
            for (int i = n; i >= 1; i--)
            {
                if (n % i == 0  &&  m % i == 0 && min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine(min);
            return min;
        }
    }
}
