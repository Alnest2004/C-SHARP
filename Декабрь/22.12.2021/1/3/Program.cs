using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C= ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число D= ");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int k = 0;
            for (int i = n + 1; i < 1000 * n; i++)
            {
                k = i;
                while (i > 0)
                {
                    sum = sum + (i % 10);
                    i = i / 10;
                }

                if (sum % c == 0 && sum % d ==0)
                {
                    Console.WriteLine("Ближайшее большее число, сумма цифр которого кратна с= " + k);
                    break;
                }
                sum = 0;
                i = k;
            }
        }
    }
}
