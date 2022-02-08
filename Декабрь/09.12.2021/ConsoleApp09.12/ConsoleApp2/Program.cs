using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите строку = ");
            string s = Console.ReadLine();
            string[] words = s.Split(' ');
            int kol = 0;
            foreach (string word in words)
            {
                if (word[0] == 'b')
                {
                    kol++;
                }
            }
            Console.WriteLine("Количество слов = " + kol);
            Console.ReadKey();
        }
    }
}
