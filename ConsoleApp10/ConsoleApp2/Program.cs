using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class A
    {
        public double a;
        public void input()
        {
            Console.Write("Введите первый аргумент уравнения:");
            a = Convert.ToDouble(Console.ReadLine());

        }
        public void output()
        {
            ///Console.Write("ответы");
            ///Console.Write(a);
        }
    }
    class B : A
    {
        public double b;

        public void input()
        {
            base.input();
            Console.Write("Введите второй аргумент уравнения:");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void output()
        {
            ///base.output();
            ///Console.Write(b);
        }
    }

    class C : B
    {
        public double c;
        public double D;
        public void input()
        {
            base.input();
            Console.Write("Введите третий аргумент уравнения:");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public void output()
        {
            double D = Math.Sqrt((b * b) - (4 * a * c));
            ///base.output();
            ///Console.Write(c);
            Console.WriteLine();
            Console.WriteLine("D={0}", D);
            if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x = {0}", x);
            }
            else if (D > 0)
            {
                double x1, x2;
                x1 = (-b + D) / (2 * a);
                x2 = (-b - D) / (2 * a);
                Console.WriteLine("D={0}, x1={1}, x2={2}", D, x1, x2);
            }
            else
            {
                Console.WriteLine("Дискриминант отрицательный(");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C rez = new C();
            rez.input();
            rez.output();

            Console.ReadKey();
        }
    }
}