using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static int f(int x)
        {
            if (x >= 10 && x <= 99)
            {
                int rev = 0;
                while (x > 0)
                {
                    rev = rev * 10 + x % 10;
                    x /= 10;
                }
                return rev;
            }
            else return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите а = ");
            int a = Convert.ToInt32(Console.ReadLine());
            float z = f(a);
            Console.WriteLine("Результат = " + z);
            Console.ReadKey();
        }
    }
}
