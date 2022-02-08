using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp21
{
    interface ICalculate // объявление интерфейса
    {
        void inte();
        void Pi();
        void Sqr();
        void Kor();
    }
    class Calculate : ICalculate
    {
        public int x = 30;

        public void inte()
        {
            Console.WriteLine(x);
        }

        public void Pi()
        {
            Console.WriteLine(Math.PI);
        }

        public void Sqr()
        {
            Console.WriteLine(Math.Pow(x, 2));
        }

        public void Kor()
        {
            Console.WriteLine(Math.Pow(x, 1 / 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();
            obj.inte();
            obj.Sqr();
            obj.Pi();
            obj.Kor();

            Console.ReadKey();
        }
    }
}