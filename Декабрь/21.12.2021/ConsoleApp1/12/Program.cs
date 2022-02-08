using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12 ");
            Console.WriteLine("Введите A ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int b = Convert.ToInt32(Console.ReadLine());
            int min = 10;
            int k = 0;
            int minim = 0;
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
                if (min > k)
                {
                    min = k;
                    minim = i;

                }
            }
            Console.WriteLine("Число с наименьшим кол-вом делителей" + minim);
        }
    }
}
