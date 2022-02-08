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
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0 && n!=i && max<i)
                {
                    max = i;
                }
            }
            Console.WriteLine("наибольший всех делителей = " + max);
            Console.ReadKey();
        }
    }
}
