using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h ");
            int h = Convert.ToInt32(Console.ReadLine());

            double y = 0;
            for (int x = a; x < b; x += h)
            {
                if (x * x - 5 * x < 0)
                {

                    y = a + b;
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
                if (0 <= x * x - 5 * x && x * x - 5 * x < 10)
                {
                    y = a - b;
                    Console.WriteLine("У равен " + y + " при х равном  " + x);
                }
                if (x * x - 5 * x >= 10)
                {
                    y = a * b;
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
            }
            Console.ReadKey();
        }
    }
}
