using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11 ");
            Console.WriteLine("Введите A ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int b = Convert.ToInt32(Console.ReadLine());
            int max = 2;
            int k = 0;
            int maxim = 0;
            for (int i = a; i <= b; i++)
            {
                k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if (max < k)
                {
                    max = k;
                    maxim = i;

                }
            }
            Console.WriteLine("Число с большим кол-вом делителей" + maxim);

        }
    }
}
