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
            
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            int first = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == ':')
                {
                    first = i;
                }
            }

            for (int i = 0; i < first; i++)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
