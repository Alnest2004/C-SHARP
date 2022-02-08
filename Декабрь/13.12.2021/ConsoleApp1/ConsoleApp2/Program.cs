using System;
using System.Text.RegularExpressions;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите текст: ");
            string stroka = Console.ReadLine();

            Console.Write("Введите корень : ");
            string poisk = Console.ReadLine();
            MatchCollection Mat4 = Regex.Matches(stroka, poisk);

            Console.WriteLine("Все вхождения строки \"{0}\" в исходной строке: ", poisk);
            foreach (Match i in Mat4)
                Console.Write(i.Index + " ");
        }
    }
}
