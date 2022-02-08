using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 17 ");
            Console.WriteLine("Введите A ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k ");
            int k = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            for (int i = a; i <= b; i++)
            {
                int n = i;
                while (i != 0)
                {
                    if ((i % 10)%2 == 0)
                    {
                        m++;
                        Console.WriteLine("Результат : " + i);
                    }
                       
                    break;
                }
                if (k == m)
                    Console.WriteLine(i);
                n /= 10;
            }
        }
    }
}
