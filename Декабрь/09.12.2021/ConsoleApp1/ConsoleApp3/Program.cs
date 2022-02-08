using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5 ");
            string line = Console.ReadLine();
            string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int max = words[0].Length, min = words[0].Length;
            foreach (string str in words)
            {
                if (str.Length > max) max = str.Length;
                if (str.Length < min) min = str.Length;
               
            }
            Console.WriteLine("Манимальное : " + min);
            Console.WriteLine("Максимальное : " + max);
        }
    }
}
