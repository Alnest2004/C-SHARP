using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Наибольший делитель числа " + n + ", не совпадающий с числом N  : ");
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    k = i;
                }
            }
            Console.WriteLine(k);
            
        }

        }
    }

