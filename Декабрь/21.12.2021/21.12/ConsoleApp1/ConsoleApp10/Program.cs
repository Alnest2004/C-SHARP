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
            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int k = 0;
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
                k++;
            }
            double rez = sum / k;
            Console.WriteLine("Результат = " + rez);
            Console.ReadKey();
        }
    }
}
