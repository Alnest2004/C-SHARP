using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Первая степень "+ n);
            Console.WriteLine("Вторая степень "+ n*n);
            Console.WriteLine("Третья степень "+ Math.Pow(n,3));
            Console.WriteLine("Четвертая степень " + Math.Pow(n, 4));
        }
    }
}
