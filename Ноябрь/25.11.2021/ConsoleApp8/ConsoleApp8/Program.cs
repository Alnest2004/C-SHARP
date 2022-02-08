using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь круга,ограниченного этой окружностью равна : "+ (d * d) / (4 * Math.PI));
            Console.ReadKey();
        }
    }
}
