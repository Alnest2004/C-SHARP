using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i;
            double a = 0;
            double k = 1;
            string s;
            Console.WriteLine("Введите число: ");
            s = Console.ReadLine();
            for (i = 0; i < s.Length; i++)
            {
                if ((s[i] != '1') && (s[i] != '0'))
                {
                    Console.WriteLine("Число введено неверно. Введите ещё раз!");
                    Console.ReadKey();
                    return;
                }
            }
            for (i = s.Length - 1; i >= 0; i--)
            {
                a += k * (s[i] - 48);
                k += k;
            }
            Console.WriteLine("Число в десятичной системе =" + a);
            Console.ReadLine();
        }
    }
}