using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите концы отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int sum;
            int k;
            for (int i = a; i <= b - 1; i++)
            {
                sum = (i + (i + 1)) / 2;
                k = 0;
                for (int j = 1; j <= sum; j++)
                {
                    if (sum % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                {

                    Console.WriteLine("{0} {1}", i, i + 1);
                }

            }
        }
    }
}