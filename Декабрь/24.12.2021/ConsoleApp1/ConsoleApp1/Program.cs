using System;

namespace ConsoleApp1
{
    class Program
    {
        static void z1(int a, int b )
        {
            int k ;
            for (int i =a; i<b+1; i++)
            {
                k = 0;
                for (int j = 1; j < b+1; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                Console.WriteLine("Для числа "+i+" кол-во делителей равно "+k);
                
            }
        }
        static void z2(int a, int b, int m)
        {
            int k;
            for (int i = a; i < b + 1; i++)
            {
                k = 0;
                for (int j = 1; j < b + 1; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if ( k == m)
                {
                    Console.WriteLine("У  числа "+ i +" кол-во делителей равно заданному числу m ");
                }

            }
        }
        static void z3(int a, int b)
        {
            int min = 2;
            int k = 0;
            int k2 = 0;
            int minumum = 0;
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
                if (min < k)
                {
                    min = k;
                    minumum = i;
                }
            }
            for (int i = a; i <= b; i++)
            {
                k2 = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k2++;
                    }
                }
                if (k2 == min)
                {
                    Console.Write(i + "  ");
                }
            }
        }
        static void z4(int a, int b, int m)
        {
            int k;
            for (int i = a; i < b + 1; i++)
            {
                k = 0;
                for (int j = 1; j < b + 1; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if (k == m)
                {
                    Console.WriteLine("У  числа " + i + " кол-во делителей равно заданному числу m ");
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
