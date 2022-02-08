using System;

namespace _77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Целые положительные числа  ");
            for (int i = a; i < b; i+=h)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
