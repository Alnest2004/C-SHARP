using System;

namespace _15
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
            Console.WriteLine("Двухзначные, произведение цифр которых нечетное  ");
            int i = 0;

            for (i = a; i < b; i++)
            {
                if (i < 100)
                {
                    if (((i % 10) * (i / 10)) % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }
    }
}
