using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый катет");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй катет");
            int k2 = Convert.ToInt32(Console.ReadLine());
            double per = k1 + k2 + Math.Sqrt( k1*k1 + k2*k2) ;
            Console.WriteLine("Периметр равен" + per);
            double pl =k1*k2/2;
            Console.WriteLine("Площадь равна" + pl);
        }
    }
}
