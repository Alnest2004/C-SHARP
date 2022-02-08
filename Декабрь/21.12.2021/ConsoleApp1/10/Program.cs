using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 16 ");
            Console.WriteLine("Введите A ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифру С ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: ");
            for (int i = a; i <= b  ; i++)
            {
                int n = i;
                while (n != 0)
                {
                    if (n % 10 == c)
                        Console.WriteLine( +i);
                    break;
                }
                n /= 10;
            }
        }
    }
}
