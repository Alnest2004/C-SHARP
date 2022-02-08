using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            string s = Console.ReadLine();
            int r = 0;
            int t = 0;
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'r')
                    r++;
                if (s[i] == 't')
                    t++;
                if (s[i] == 'k')
                    k++;
            }
            Console.WriteLine("Букв k в строке = " + k);
            Console.WriteLine("Букв t в строке = " + t);
            Console.WriteLine("Букв r в строке = " + r);
        }
    }
}
