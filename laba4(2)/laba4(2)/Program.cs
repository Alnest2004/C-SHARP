using System;

namespace laba4_2_
{
    class Program
    {
        static double kor(double x1, double y1, double x2, double y2)
        {

            double korr = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return korr;
        }

        static double srav(double x1, double x2, double x3)
        {
            if ((x1 <= x2) && (x1 <= x3))
            {
                return x1;
            }
            else if ((x2 <= x3) && (x2 <= x1))
            {
                return x2;
            }
            else
            {
                return x3;
            }
        }
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, x4, y4;
            double a, b, c;
            x1 = 2; x2 = 1; x3 = 9; x4 = 1;
            y1 = 9; y2 = 5; y3 = 9; y4 = 4;

            a = kor(x1, x3, y1, y3);
            b = kor(x2, x3, y2, y3);
            c = kor(x4, x3, y4, y3);
            double minn = srav(a, b, c);

            Console.WriteLine("Первое расстояние = " + a);
            Console.WriteLine("Второе расстояние = " + b);
            Console.WriteLine("Второе расстояние = " + c);
            Console.WriteLine("Минимальное расстояние = " + minn);

        }
    }
}
