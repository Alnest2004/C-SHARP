using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            int countBefore = str.IndexOf(';');
            int countAfter = str.Length - countBefore - 1;
            Console.WriteLine("Символов после " +countAfter);
            Console.WriteLine("Символов до " + countBefore);
        }
    }
}
