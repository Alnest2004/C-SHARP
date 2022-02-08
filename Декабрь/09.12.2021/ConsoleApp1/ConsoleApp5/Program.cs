using System;
using System.Text.RegularExpressions;

namespace ConsoleApp5
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
