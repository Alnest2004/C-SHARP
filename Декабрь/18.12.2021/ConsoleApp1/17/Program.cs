using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Трехзначные, которые начинаются и заканчиваются на одинакувую цифру: ");
            int i = 0;

            for (i = a; i < b; i++)
            {
                if (i >100 && i<1000)
                {
                    if (i%10 == i/100)
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }
    }
}
