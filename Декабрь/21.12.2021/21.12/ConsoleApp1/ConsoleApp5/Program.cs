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
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число D");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Делители = ");
            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0 && i % c == 0 && i%d==0)
                {
                    Console.Write(i + "  ");
                }
            }
            Console.ReadKey();
        }
    }
}
