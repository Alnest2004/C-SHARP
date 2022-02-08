using System;

using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string a = "Язык программирования С++. Мы учимся программировать на С++";
            Regex r = new Regex(@"\+\+");
            a = r.Replace(a, "#");
            Console.WriteLine(a);
        }
    }
}