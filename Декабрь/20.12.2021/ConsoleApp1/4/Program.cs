using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
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
                if (Math.Abs(x)<=0.1)
                {

                    y = x*x*x-0.1;
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
                if (0.1<Math.Abs(x)&& Math.Abs(x)<=0.2)
                {
                    y = 0.2*x-0.1;
                    Console.WriteLine("У равен " + y + " при х равном  " + x);
                }
                if (Math.Abs(x)>0.2)
                {
                    y = x*x*x+0.1;
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
            }
            Console.ReadKey();
        }
    }
}
