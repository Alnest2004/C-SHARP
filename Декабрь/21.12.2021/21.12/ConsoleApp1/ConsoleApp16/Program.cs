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
            Console.WriteLine("Задание 17");
            Console.WriteLine("Введите начало и конец отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int c = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int n = i;
                while (n != 0)
                {
                    if (n % 10 == c)
                    {
                        Console.WriteLine("Результат = " + i);
                    }
                    break;
                }
                n /= 10;
            }
            Console.ReadKey();
        }
    }
}
