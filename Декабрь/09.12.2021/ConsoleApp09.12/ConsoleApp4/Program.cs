using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            int kolz = 0;
            int koltz = 0;
            int koldv = 0;
            for (int i=0; i<s.Length; i++)
            {
                if (s[i] == '*')
                {
                    kolz++;
                }
                if (s[i] == ';')
                {
                    koltz++;
                }
                if (s[i] == ':')
                {
                    koldv++;
                }
            }
            Console.WriteLine("Количество * = " + kolz + " Количество ; = " + koltz + " Количессвто : = " + koldv);
            Console.ReadKey();
        }
    }
}
