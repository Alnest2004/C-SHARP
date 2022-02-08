using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало и конец отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            Console.Write("Введите ровно k делителей=");
            int kk = int.Parse(Console.ReadLine());
            Console.WriteLine("Числа у которых ровно k");
            for (int i = a; i <= b; i++)
            {
                k = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if (kk == k)
                {
                    Console.Write(i+"  ");
                }
            }
            Console.ReadKey();
        }
    }
}
