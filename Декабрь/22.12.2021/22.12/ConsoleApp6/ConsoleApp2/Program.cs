using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите число N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C= ");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int k = 0;
            for (int i = n + 1; i < 2 * n; i++)
            {
                k = i;
                while (i > 0)
                {
                    sum = sum + (i % 10);
                    i = i / 10;
                }

                if (sum % c == 0)
                {
                    Console.WriteLine(" Ближайшее большее число, сумма цифр которого кратна с= " + k);
                    break;
                }
                sum = 0;
                i = k;
            }

        }
    }
}