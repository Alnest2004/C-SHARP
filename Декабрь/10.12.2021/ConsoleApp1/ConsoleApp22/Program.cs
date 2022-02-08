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
            Console.WriteLine("Строка:");
            string[] wrd = Console.ReadLine().ToLower().Split(" -,.:()[]{}\'\"".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in wrd)
                if (w[0] == w[w.Length - 1])
                    Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
