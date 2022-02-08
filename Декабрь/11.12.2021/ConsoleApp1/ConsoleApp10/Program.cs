using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.WriteLine("Введите текст = ");
            string s = Console.ReadLine();
            char c = 'a';
            double lit = 0;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    lit++;
                }
            }
            double kol = ((double)(lit / s.Length)) * 100;

            Console.WriteLine("Отношение букв к длине текста : " + kol + "%");
            Console.ReadKey();
        }
    }
}
