using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h ");
            int h = Convert.ToInt32(Console.ReadLine());
            double y = 0;
            for (int x = a; x < b; x += h)
            {
                if (Math.Abs(x)<3)
                {
                    y = Math.Sin(x);
                    y = Math.Round(y, 2);
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
                if (Math.Abs(x) >= 3 && Math.Abs(x) < 9)
                {
                    
                    y = Math.Sqrt(x * x + 1) / Math.Sqrt(x * x + 5) ;
                    y = Math.Round(y, 2);
                    Console.WriteLine("У равен " + y + " при х равном  " + x);
                }
                if (Math.Abs(x)>=9)
                {
                   
                    y = Math.Sqrt(x*x+1)-Math.Sqrt(x*x+5);
                    y = Math.Round(y, 2);
                    Console.WriteLine("У равен " + y + " при х равном " + x);
                }
            }
            Console.ReadKey();
        }
    }
}
