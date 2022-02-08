using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите строку : ");
            string s = Console.ReadLine();
            string s1 = "";
            int k = 0;
            int inc = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!s1.Contains(s[i]))
                {
                    s1 += s[i];
                    {
                        inc++;
                    }
                }
            }
            Console.WriteLine("Различных элементов : " + inc);
        }
    }
}
