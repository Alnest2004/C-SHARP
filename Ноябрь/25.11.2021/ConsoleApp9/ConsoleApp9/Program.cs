using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, R, A, B, C;

            Console.WriteLine("Введите угол A");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите угол B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите угол C");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  радиус описанной окружности ");
            R = Convert.ToDouble(Console.ReadLine());
            a = Math.Pow(R, 2) * (2 + Math.Cos(A + B - C));
            Console.WriteLine("Площадь круга = "+ a);
            Console.ReadLine();
        }
    }
}
