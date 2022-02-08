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
            Console.WriteLine("Введите концы отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int sum;
            int k = 0;
            for (int i = a; i <= b - 1; i++)
            {
                k = 0;
                sum = i * (i + 1);
                for (int j = 1; j <= sum; j++)
                {
                    if (sum % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                {

                    Console.WriteLine("{0} {1}", i, i + 1);
                }

            }
            Console.ReadKey();
        }
    }
}
