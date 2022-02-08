using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            string rezult = "";
            foreach (var i in arr)
                rezult += new string(i.Reverse().ToArray()) + " ";
            Console.WriteLine(rezult);

        }
    }
}
