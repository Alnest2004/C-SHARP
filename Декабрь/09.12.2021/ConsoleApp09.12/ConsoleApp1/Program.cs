using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите строку, оканчивающуюся точкой");
            string s = Console.ReadLine();
            int k = 1;
            if (s[s.Length - 1] == '.')
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                        k++;
                }
                Console.WriteLine("Слов в строке = " + k);
            }
        }
    }
}
