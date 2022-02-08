using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            int sum = 0;
            int max = 0;
            for (int i =0; i<s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    sum = sum + 1;
                }
                else
                {
                    if (sum > max)
                    {
                        max = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine("Максимум = " + max+" Символа а");
            Console.ReadKey();

        }
    }
}
