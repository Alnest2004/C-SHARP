using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону равностороннего треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            double h, r, R, S;
            h = Math.Sqrt(3) / 2 * a;
            S = 0.5 * a * h;
            r = (2 * S) / (3 * a);
            R = Math.Pow(a, 3) / (4 * S);
            Console.WriteLine("Высота = "+ h);
            Console.WriteLine("Площадь ="+ S);
            Console.WriteLine("Радиус вписанной = "+ r);
            Console.WriteLine("Радиус описанной = "+ R);
            
        }
    }
    
}
