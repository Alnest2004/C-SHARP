using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            string sn = "";
            for (int i=0; i<s.Length; i++)
            {
                if (s[i] != '*')
                {
                    sn = sn + s[i] + s[i];
                }
            }
            for (int i = 0; i < sn.Length; i++)
            {
                if (sn[i] == '*')
                {
                    sn = sn.Replace("*"," ");
                }
            }
            Console.WriteLine(sn);
            Console.ReadKey();
        }
    }
}
