using System;

namespace ConsoleApp5
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
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координаты  точки у2 ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double rast = Math.Sqrt((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y));
            Console.WriteLine("Расстояние = " + rast );

        }
    }
}
