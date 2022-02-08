using System;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите строку : ");
            string line = Console.ReadLine();
            Regex regex = new Regex(@"\b(\p{L}\p{L}*?\1\b", RegexOptions.IgnoreCase);
            foreach (Match match in regex.Matches(line))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

