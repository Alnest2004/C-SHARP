using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            int kol = 0;
            int m = 0;
            for (int i=0; i<s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    kol++;
                }
                else
                {
                    if (kol > m)
                    {
                        m = kol;
                    }
                    kol = 0;
                }
            }
            Console.WriteLine("Максимальная длина = " + m);
            Console.ReadKey();

        }
    }
}
