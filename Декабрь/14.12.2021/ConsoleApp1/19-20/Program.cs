using System;

namespace _19_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" трехзначное число ");
            Console.WriteLine("Введите значение числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 10;
            int a1 = y % 10;
            Console.WriteLine("Введите значение числа Z = ");
            int zet = Convert.ToInt32(Console.ReadLine());
            int z = zet / 10;
            int z1 = zet % 10;
            int x = a*1000+a1*100+z*10+z1;
            Console.WriteLine("Ответ : х = " + x);
            Console.WriteLine("четырехзначное  число ");
            Console.WriteLine("Введите значение  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 10;
            int b1 = y1 % 10;
            Console.WriteLine("Введите значение числа Z = ");
            int zet1 = Convert.ToInt32(Console.ReadLine());
            int c = zet1 / 100;
            int c1 =( zet1 % 100)/10;
            int c2 = zet1 % 10;
            int x1 = b*10000+b1*1000+c*100+c1*10+c2;
            Console.WriteLine("Ответ : х = " + x1);
        }
    }
}
