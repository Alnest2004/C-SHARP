using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            if (login_regex.Match(login).Success)
                Console.WriteLine("Логин верный");
            else
                Console.WriteLine("Логин не верный");
        }
    }
}
