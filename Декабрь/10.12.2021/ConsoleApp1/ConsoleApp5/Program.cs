using System;
using System.Linq;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            var s = Console.ReadLine();
            foreach ( var item in s.Split (' ').OrderBy (x=>x))
                {
                Console.WriteLine(item);
            }
        }
    }
}
