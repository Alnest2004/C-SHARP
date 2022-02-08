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
            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень C");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i = 0; i <= n; i++)
            {
                if (n==Math.Pow(c,i))
                {
                    k++;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("НЕ Является");
            }
            if (k == 1)
            {
                Console.WriteLine("Является");
            }
            Console.ReadKey();
        }
    }
}
