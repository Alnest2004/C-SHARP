using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            int first=0 , last=0;
            for (int i =0; i<s.Length; i++)
            {
                if (s[i] == '(')
                {
                    first = i;
                }

                if (s[i] == ')')
                {
                    last = i;
                }
            }

            for (int i = first+1; i< last; i++)
            {
                Console.Write(s[i]);
            }

            Console.ReadKey();
        }
    }
}
