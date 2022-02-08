using System;

namespace zad3._1
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
        
            Console.WriteLine("Дробь при сокращении принимает вид : " + n / Kol(n, m) + "/" + m / Kol(n, m));
        }
        static int Kol(int n, int m)
        {
            int max = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0  && max < i && m % i == 0  && max<i)
                {
                    max = i;
                }
            }
            
            return max;
        }
    }
}
