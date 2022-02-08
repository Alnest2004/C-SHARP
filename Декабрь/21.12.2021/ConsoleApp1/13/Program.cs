using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13 ");
            Console.WriteLine("Введите A ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите к ");
            int k = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        s++;
                    }
                }
                if ( k==s )
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
