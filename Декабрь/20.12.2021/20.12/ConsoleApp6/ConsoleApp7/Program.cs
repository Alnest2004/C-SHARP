using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h = ");
            int h = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (int i = a; i <= b; i += h)
            {
                k++;
                if (i<0)
                {
                    double rez = -4;
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (i>=0 && 1>i)
                {
                    double rez =i*i+3*i+4;
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (i>=1)
                {
                    double rez = 2;
                    Console.Write($"Значение {k} = {rez}  |");
                }
            }
            Console.ReadKey();
        }
    }
}
