using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите угол y");
            int y = Convert.ToInt32(Console.ReadLine());
            double pl =Math.Abs( A * B * Math.Cos (Math.PI * y / 180));
            Console.WriteLine("Площадь = "+pl);


        }
    }
}
