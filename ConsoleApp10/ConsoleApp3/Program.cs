using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Point
    {
        public double x1;
        public double y1;
        public void input()
        {
            Console.Write("Введите x:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y:");
            y1 = Convert.ToDouble(Console.ReadLine());

        }
        public void output()
        {
            Console.WriteLine("это икс=");
            Console.WriteLine(x1);
            Console.WriteLine("это игрик=");
            Console.WriteLine(y1);

        }
    }
    class ColoredPoint : Point
    {
        public string color;

        public void input()
        {
            base.input();
            Console.WriteLine("Введите цвет:");
            color = Console.ReadLine();
        }

        public void output()
        {
            base.output();
            Console.WriteLine("цвет");
            Console.WriteLine(color);
        }
    }

    class Circle : Point
    {
        public double rad;
        public double plshk;
        public double dlina;

        public void input()
        {
            base.input();
            Console.Write("Введите радиус");
            rad = Convert.ToDouble(Console.ReadLine());
            plshk = 3.14 * rad * rad;
            dlina = 2 * 3.14 * rad;
        }

        public void output()
        {
            base.output();
            Console.WriteLine("Площадь");
            Console.WriteLine(plshk);
            Console.WriteLine("Длина");
            Console.WriteLine(dlina);

        }
    }

    class Line : Point
    {
        public int len;

        public void input()
        {
            base.input();
            Console.WriteLine("Введите длину строки:");
            len = Convert.ToInt32(Console.ReadLine());
        }

        public void output()
        {
            base.output();
            Console.WriteLine(len);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Координаты Point");
            Point rez1 = new Point();
            rez1.input();
            rez1.output();
            Console.WriteLine("Координаты ColoredPoint");
            ColoredPoint rez2 = new ColoredPoint();
            rez2.input();
            rez2.output();
            Console.WriteLine("Координаты Line");
            Line rez3 = new Line();
            rez3.input();
            rez3.output();
            Console.WriteLine("Координаты Circle ");
            Circle rez4 = new Circle();
            rez4.input();
            rez4.output();


            Console.ReadKey();
        }
    }
}