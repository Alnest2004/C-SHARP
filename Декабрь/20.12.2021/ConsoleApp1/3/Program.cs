using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение а ");
            int n = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            for (int x = a; x < b; x += h)
            {
                if (x<n)
                {
                   
                    y = 0;
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
                if (x>n)
                {
                    y = (x - a) / (x + a);
                    Console.WriteLine("У равен " + y + " при х равном  " + x);
                }
                if (x==a)
                { 
                    y = 1;
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
            }
            Console.ReadKey();
        }
    }
}
