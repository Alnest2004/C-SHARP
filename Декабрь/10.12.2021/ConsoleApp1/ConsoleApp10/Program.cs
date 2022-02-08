using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.WriteLine("Введите что искать");
            string find = Console.ReadLine();
            char[] strs = new char[] { ' ', ',', '.', '!', '?', ':' };
            int count = str.Split(strs, StringSplitOptions.RemoveEmptyEntries).Count(x => x == find);
            Console.WriteLine(count);
        }
    }
}
