using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффециент а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффециент b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффециент c");
            int c = Convert.ToInt32(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = ((-1) * b - Math.Sqrt(D)) / 2*a;
                double x2 = ((-1) * b + Math.Sqrt(D)) / 2*a;
                Console.WriteLine("x1=  "+x1+" x2= "+x2);
            }
            if (D == 0)
            {
                double x1 = (-1) * b  / 2*a;
                double x2 = (-1) * b / 2*a;
                Console.WriteLine("x1=  " + x1 + " x2= " + x2);
            }
            if (D < 0)
            {
                Console.WriteLine("Дискриминант отрицательный. Уравнение не может быть решено.");
            }

        }
    }
}
