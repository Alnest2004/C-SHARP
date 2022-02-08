using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C ");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < s ; i++)
            {
                if (Math.Pow(n,i)==s)
                {
                    Console.WriteLine("Да, является");
                }
            }
          
        }
    }
}
