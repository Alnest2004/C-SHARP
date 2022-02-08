using System;
using System.Linq;

namespace _3._4
{
     class Program
     {
       static int Min( int x, int y)
        {
            return x < y ? x : y;
        }
        static int Max( int x, int y)
        {
            return x > y ? x : y;
        }
        static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;

            }
            else
            {
                var min = Min(a, b);
                var max = Max(a, b);
                return GCD(max - min, min);

            }
        }
        static void Main( string[] args)
        {
            Console.WriteLine("Введите n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{i + 1} число :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
                var res = a.Aggregate((x, y) => GCD(x, y));
                Console.WriteLine($"НОД - {res}");
            
            Console.ReadKey();

        }
    }
}
