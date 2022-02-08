using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите число N=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C=");
            int c = Convert.ToInt32(Console.ReadLine());
            for(int i=n; i<=100000; i++)
            {
                if (i % c == 0 && i!=n)
                {
                    Console.WriteLine("ближайшее большее = " + i);
                    break;
                }
            }


            Console.ReadKey();
        }
    }
}
