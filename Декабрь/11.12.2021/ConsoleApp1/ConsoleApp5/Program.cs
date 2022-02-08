using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            string sen = "отредактировать предложение удаляя из него слова с нечётными номерами.";
            string[] words = sen.Split(' ', ',', '.');
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}", words[i]);
                }
                else
                {
                    string reverse = new string(sen.Reverse().ToArray());
                    words[i] = reverse.ToString();
                    Console.Write(words[i]);
                }
            }
        }
    }
}
