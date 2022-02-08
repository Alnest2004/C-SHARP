using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.WriteLine("Введите начало и конец отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            int y = 0;
            Console.WriteLine();
            for (int i = a; i <= b; i++)
            {
                y = 0;
                k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k += j;
                    }
                }
                for (int t = 1; t <= k; t++)
                {
                    if (k % t == 0) y++;
                }
                if (y == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
