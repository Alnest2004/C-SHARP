using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string stroka = "37-35-67 паааппар gппаапап а па п  11-33-55 888-999 папаррат rfrjqnj 23-12-33 папап 33-44-55 " + "\n";
            Console.WriteLine("текст:" + stroka);
            var result = Regex.Matches(stroka, @"(?<= )\d{2,3}-\d{2}-\d{2}|\d{3}-\d{3}(?= )");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
