using System;

namespace ConsoleApp1
{

    class Program
    {
        static void zad1()
        {
            Console.WriteLine("Введите три двухзначных числа");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма цифр каждого из чисел " + (a1 / 10 + a1 % 10) +"   " + (a2 / 10 + a2 % 10) +"   "+ (a3 / 10 + a3 % 10));
        }
        static void zad3()
        {
            Console.WriteLine("Введите два натуральных числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            int nok = 0;
            int nod = 0;
            int min = Math.Min(a, a1);
            Console.WriteLine(min);

            for (int i = 0; i < (a * a1 + 1); i++)
            {
                if (i % a == 0 && i % a1 == 0)
                {
                    nok = i;
                }
            }

            while (a1 != 0)
            {
                var t = a1;
                a1 = a % a1;
                a = t;
                nod = t;
            }
            
            Console.WriteLine("НОК" + nok);
            Console.WriteLine("НОД" + nod);
        }
    
        static void zad12()
        {
            int k;
            int d;
            int sum;

            Console.WriteLine("Введите границы генерируемого количества цифр числа.\n");
            Console.Write("Минимальная граница = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Максимальная граница = ");
            int b = int.Parse(Console.ReadLine());
            // Генерирование количества цифр.
            Random x = new Random();
            int n = x.Next(a, b);
            // Выводим количество цифр в числе пользователю.
            Console.WriteLine("\nколичество цифр в числе= " + n);

            sum = 0;
            d = n;
            do
            {
                k = d % 10;
                if (k % 2 == 1) sum = sum + n;
            }
            while (d > 0);

            do
            {
                Console.WriteLine("Сумма=" + sum);
            }
            while (n >= 0);

            d = 0;
            do
            {
                k = sum % 10;
                if (k % 2 == 0) d++;
                sum = sum / 10;
            }
            while (sum > 0);

            Console.WriteLine("Количество четных цифр в сумме=" + d);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            zad1();
            zad3();
            zad12();
        }

    }
}
