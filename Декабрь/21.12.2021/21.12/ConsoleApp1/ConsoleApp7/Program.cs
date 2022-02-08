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
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите число N");
            double n = Convert.ToInt32(Console.ReadLine());
            double sr = 0;
            double k = 0;
            for (double i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {
                    k++;
                    sr = sr+i;
                }
            }
            double sum = sr / k;
            Console.WriteLine("среднее всех делителей = " + sum);
            Console.ReadKey();
        }
    }
}
