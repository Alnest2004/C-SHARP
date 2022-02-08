using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите строку : ");
            string line = Console.ReadLine();
            Regex reg = new Regex("abc");
            MatchCollection math = reg.Matches(line);
            Console.WriteLine("Найдено групп abc, входящих в строку " + math.Count);
            Console.ReadKey();
        }
    }
}
