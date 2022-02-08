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
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i=1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    k++;
                }
            }
            if (k > 2)
            {
                for (int i = 1; i <= n; i++)
                {

                    if (n % i == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Число простое");
            }
            Console.ReadKey();
        }
    }
}
