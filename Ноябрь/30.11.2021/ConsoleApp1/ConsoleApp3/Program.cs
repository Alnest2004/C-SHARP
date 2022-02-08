using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n = ");
            double n = Convert.ToDouble(Console.ReadLine());
            for(int i =0; i<n;i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
