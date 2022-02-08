using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");

            string s = Console.ReadLine();
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool ft = false;
            Console.WriteLine("Слова из трех букв : ");
            foreach (var word in words)
                if (word.Length == 3)
                {
                    Console.WriteLine(word); ft = true;
                }
            if (!ft)
                Console.WriteLine("Таких слов нет");
        }
    }
}
