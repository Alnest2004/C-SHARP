using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            char zad15;
            zad15 = Char.Parse(Console.ReadLine());
            Console.WriteLine($"Символ = {zad15}, порядковый номер = {(byte)zad15}");
            Console.WriteLine($"Символ после = {(char)(zad15 + 1)}, порядковый номер = {(byte)zad15 + 1}");
            Console.WriteLine($"Символ до = {(char)(zad15 - 1)}, порядковый номер = {(byte)zad15 - 1}");

        }
    }
}
