using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Целые положительные числа  ");
            double y = 0;
            for (int i = a; i < b; i += h)
            {
                if (i >= 0.9)
                {
                    y = 1 / (0.1 - i) * (0.1 - i);
                    y = Math.Round(y, 2);
                    Console.WriteLine("У равен " + y + " при х равном " + i);
                }
                if (i >= 0 && i < 0.9)
                {

                    y = 0.2 * i + 0.1;
                    y = Math.Round(y, 2);
                    Console.WriteLine("У равен " + y + " при х равном  " + i);
                }
                if (i < 0)
                {

                    y = i * i + 0.2;
                    y = Math.Round(y, 2);
                    Console.WriteLine("У равен " + y + " при х равном " + i);
                }
            }
            Console.ReadKey();

        }



    }
}
