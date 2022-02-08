using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(" " + i * j);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}