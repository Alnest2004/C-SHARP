using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 16");
            for (int i = 10; i < 100; i++)
            {
                if (Math.Abs(i % 10 - (i - i % 10) / 10) <= 2)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
