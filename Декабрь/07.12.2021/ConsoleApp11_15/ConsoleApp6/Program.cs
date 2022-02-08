using System;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            Console.Write("Введите n:");
            int n = int.Parse(Console.ReadLine());
            double[] ar = new double[n];
            double p1 = 1, p2 = 1;
            for (int i = 0; i < n; i++)
            {
                ar[i] = r.Next(1, 5);
                ar[i] -= 0.5;
                if (i % 2 == 0)
                    ar[i] *= (-1);
                Console.Write(ar[i] + " ");
                if (ar[i] < 0)
                    p1 *= ar[i];
                else
                    p2 *= ar[i];
            }
            Console.WriteLine();
            Console.Write($"Произведение отрицательных: {p1} Произведение положительных: {p2}");
            bool isTrue = Math.Abs(p1) > Math.Abs(p2) ? true : false;
            Console.WriteLine("\nabs(p1)>abs(p2)? " + isTrue);
            Console.ReadKey();

        }
    }
}