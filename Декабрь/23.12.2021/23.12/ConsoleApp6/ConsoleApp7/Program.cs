using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public static int f(int x)
        {
            int rez = 0;
            if (x >= 100)
            {
                rez = (x / 10) % 10;
                
            }
            else
            {
                rez = x / 10;
            }
            return rez;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите а = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            float z = f(a) + f(b);
            Console.WriteLine("Результат = " + z);
            Console.ReadKey();
        }
    }
}
