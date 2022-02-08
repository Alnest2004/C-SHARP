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
            Console.WriteLine("Введите a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h = ");
            int h = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for(double i=a; i<=b; i+=h)
            {
                k++;
                if (i * i + 2 * i + 1 < 2)
                {
                    double rez = i * i;
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (2<=(i * i + 2 * i + 1) && (i * i + 2 * i + 1<3))
                {
                    double rez = 1 / (i * i - 1);
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (i * i + 2 * i + 1 >= 3)
                {
                    double rez = 0;
                    Console.Write($"Значение {k} = {rez}  |");
                }
            }
            Console.ReadKey();
        }
    }
}
