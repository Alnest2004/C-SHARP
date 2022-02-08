using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h = ");
            int h = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (double i = a; i <= b; i += h)
            {
                k++;
                if (i<1)
                {
                    double rez = Math.Pow((i*i-1),2);
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (i>1)
                {
                    double rez = 1/Math.Pow(1+i,2);
                    Console.Write($"Значение {k} = {rez} |");
                }
                if (i==1)
                {
                    double rez = 0;
                    Console.Write($"Значение {k} = {rez}  |");
                }
            }
            Console.ReadKey();
        }
    }
}
