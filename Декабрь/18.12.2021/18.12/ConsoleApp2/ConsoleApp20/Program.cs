using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 20");
            for (int i = 100; i < 1000; i++)
            {
                int a = i / 100;
                int b = i / 10 % 10;
                int c = i % 10;
                int proizv = a * b * c;

                if (proizv%2==0) Console.Write("{0}{1}{2}, ", a, b, c);
            }
            Console.ReadKey();
        }
    }
}
