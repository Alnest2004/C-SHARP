using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            for(int a = 10; a <= 99; a++)
            {
                if (((a / 10) + (a % 10)) % 2 == 0) Console.WriteLine(a);
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
