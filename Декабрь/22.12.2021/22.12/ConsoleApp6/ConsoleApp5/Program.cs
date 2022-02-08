using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число N");
            int k;
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите С");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите D");
            int d = int.Parse(Console.ReadLine());
            int sum;
            for (int i = n; i > 0; i--)
            {
                int j = i;
                sum = 0;
                while (j > 0)
                {
                    sum += j % 10;
                    j /= 10;
                }
                if (sum % c == 0 || sum % d == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}