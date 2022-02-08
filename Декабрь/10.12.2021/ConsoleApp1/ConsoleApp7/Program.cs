using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите слово:");
            string str = Console.ReadLine();
            bool b = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1]) { b = false; }
            }
            Console.WriteLine("Слово " + ((b) ? "является " : "не является ") + "палиндромом");

        }
    }
}
