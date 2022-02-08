using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double aa, bb, cc, xx;
            Console.WriteLine("Введите стороны треугольника a");
            aa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника b");
            bb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника c");
            cc = Convert.ToDouble(Console.ReadLine());


            xx = (aa * aa + bb * bb - cc * cc) / (2 * aa * bb);
            if (xx == 0)
            {
                Console.WriteLine("угол гамма: 90 градусов");
            }
            else
            {
                xx = Math.Atan(Math.Sqrt((1 - xx * xx) / xx));
                xx = 180 / Math.PI * xx;
                Console.WriteLine("угол гамма:" + Math.Abs(xx) + " градусов");
            }

            xx = (cc * cc + bb * bb - aa * aa) / (2 * cc * bb);


            if (xx == 0)
            {
                Console.WriteLine("угол альфа: 90 градусов");
            }
            else
            {
                xx = Math.Atan(Math.Sqrt((1 - xx * xx) / xx));
                xx = 180 / Math.PI * xx;
                Console.WriteLine("угол гамма:" + Math.Abs(xx) + " градусов");
            }

            xx = (aa * aa + cc * cc - bb * bb) / (2 * cc * aa);


            if (xx == 0)
            {
                Console.WriteLine("угол бета: 90 градусов");
            }
            else
            {
                xx = Math.Atan(Math.Sqrt((1 - xx * xx) / xx));
                xx = 180 / Math.PI * xx;
                Console.WriteLine("угол бета:" + Math.Abs(xx) + " градусов");
            }
        }
    }
}
