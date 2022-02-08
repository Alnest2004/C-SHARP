using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        delegate int Sum (int n);

        static Sum Print()
        {
            int rez = 0;

            Sum del = delegate (int n)
            {
                Random rnd = new Random();

                for (int i=0; i<n; i++)
                {
                    int ran = rnd.Next(10, 30);
                    Console.WriteLine(ran);
                    if (ran % 2 == 0)
                    {
                        rez = rez + ran;
                    }
                   
                }
                return rez;
            };
            return del;
        }

        static void Main()
        {
            Sum del1 = Print();
            Console.WriteLine("Введите количество рандомных чисел");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(del1(n));
            Console.ReadKey();
            

            
        }
    }
}
