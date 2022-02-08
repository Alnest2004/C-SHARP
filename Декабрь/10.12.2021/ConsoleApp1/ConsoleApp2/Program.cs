using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите строку : ");
            string line = Console.ReadLine();
            string rep = line.Replace(" ", ", ");
            Console.WriteLine(rep);

        }
    }
}
