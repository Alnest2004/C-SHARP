using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Делители числа "+ n + ": ");
            for (int i=1; i<n+1; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(" "+i);
                }
            }
        }
    }
}
