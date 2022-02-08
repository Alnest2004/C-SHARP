using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 ");
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            string[] words = s.Split(' ');
            int nomer;
            foreach (string str in words)

                foreach (char ch in str)
                    if (ch == 'к' || ch == char.ToUpper('к'))
                    {
                        nomer = Array.IndexOf(words, str);
                        Console.WriteLine(words[nomer]);
                    }
        }
    }
}
