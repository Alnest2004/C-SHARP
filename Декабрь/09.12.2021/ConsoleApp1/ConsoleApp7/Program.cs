using System;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
         
            var str = "Марина; Света; Катя; Должность: ";
            Console.WriteLine(str);
            var array = str.Replace(":", "").Split(';');
            int count = (from a in array where a[ a.Length - 1] == 'а' select a).Count();
            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
