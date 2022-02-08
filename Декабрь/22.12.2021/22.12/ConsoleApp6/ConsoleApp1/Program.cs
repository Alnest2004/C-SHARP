using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число N");
            int k;
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2) { Console.WriteLine(i); break; }
            }
        }
    }
}