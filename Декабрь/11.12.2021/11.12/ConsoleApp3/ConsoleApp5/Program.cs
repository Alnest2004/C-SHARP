using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "текст, любой текст который я хочуу";
            char[] characters = text.Distinct().ToArray();
            string result = String.Join("", characters);
            Console.WriteLine($"Исходная строка: {text}");
            Console.WriteLine($"Конечная строка: {result}");
            Console.ReadKey();
        }
    }
}
