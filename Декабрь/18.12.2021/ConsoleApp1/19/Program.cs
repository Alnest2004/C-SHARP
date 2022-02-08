using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 19");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Трехзначные, сумма цифр которых является нечетной : ");
            int i = 0;

            for (i = a; i < b; i++)
            {
                if (i > 100 & i < 1000)
                {
                    if (((i % 10) + (i / 100) + (i%100/10))% 2 !=0 )
                    {
                        Console.WriteLine(i);
                    }
                }


            }
        }
    }
}
