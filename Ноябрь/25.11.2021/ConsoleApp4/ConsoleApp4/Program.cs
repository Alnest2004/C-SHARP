using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int a1 = Convert.ToInt32(Console.ReadLine());
            double sr1 = (a * a + a1 * a1) / 2;
            Console.WriteLine("Среднее арифметическое квадратов "+sr1);
            double sr2 = Math.Sqrt(Math.Abs(a) * Math.Abs(a1));
            Console.WriteLine("Среднее геометрическое модулей " + sr2);
        }
    }
}
