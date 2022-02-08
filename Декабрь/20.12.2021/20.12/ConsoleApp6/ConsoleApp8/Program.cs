using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
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
                if (Math.Abs(i)<=1)
                {
                    double rez = i*i-1;
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (Math.Abs(i) > 1 && 2 >= Math.Abs(i))
                {
                    double rez = 2*i-1;
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (Math.Abs(i) > 2)
                {
                    double rez = 2;
                    Console.Write($"Значение {k} = {rez}  |");
                }
            }
            Console.ReadKey();
        }
    }
}
