using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Координаты  точки x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты  точки y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты точки x2");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты  точки у2 ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты точки x3");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты точки y3");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double A = Math.Sqrt((x1 - x)*(x1 - x) + (y1 - y)* (y1 - y));
            double B = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y) * (y2 - y));
            double C = Math.Sqrt((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y));
            double P = A + B + C;
            Console.WriteLine("Периметр"+P);
            double P2 = P / 2;
            double pl = P * (P2 - A) * (P2 - B) * (P2 - C);
            Console.WriteLine("Площадь" + pl);







        }
    }
}
