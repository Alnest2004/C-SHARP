using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            string str = "Удаляем   лишние   пробелы ";
            Console.WriteLine(str);
            Console.WriteLine(Regex.Replace(str, "[ ]+", " "));
            Console.ReadKey(true);
        }
    }
}
