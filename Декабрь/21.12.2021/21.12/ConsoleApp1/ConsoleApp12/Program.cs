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
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите начало и конец отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int min = 10;
            int k = 0;
            int k2 = 0;
            int minumum = 0;
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
                if (min > k)
                {
                    min = k;
                    minumum = i;
                }
            }
            for (int i=a; i <= b; i++)
            {
                k2 = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k2++;
                    }
                }
                if (k2==min)
                {
                    Console.Write(i+"  ");
                }
            }

            Console.ReadKey();
        }
    }
}
