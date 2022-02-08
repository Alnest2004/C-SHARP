using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i<b; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine("Чисел, кратных 3 "+i);
                }
            }
        }
    }
}
