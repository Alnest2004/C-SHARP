using System;

namespace ConsoleApp1
{
    class Program
    {
        static void z1(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                int n = i;
                while (i != 0)
                {
                    if ((i % 10) % 2 != 0)
                    {
                        sum = sum + i;

                    }

                }
                Console.WriteLine("Результат : " + sum);
                n /= 10;
            }
        }
     
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Введите A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задание 1");
            z1(a, b);
            Console.WriteLine("Введите заданное число m  = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задание 2");
            z2(a, b, m);
            Console.WriteLine("Задание 3");
            z3(a, b);

        }
    }
}
