using System;
using System.Linq;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            string text = "текст, любой текст который я хочуу";
            char[] characters = text.Distinct().ToArray();
            string result = String.Join("", characters);
            Console.WriteLine($"Исходная строка: {text}");
            Console.WriteLine($"Конечная строка: {result}");
            Console.ReadKey();
        }
    }
}
