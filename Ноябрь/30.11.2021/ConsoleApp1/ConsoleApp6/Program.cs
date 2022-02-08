using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    sum = sum + a;
                }
            }
            Console.WriteLine("Сумма"+sum);
        } 
    }
}
