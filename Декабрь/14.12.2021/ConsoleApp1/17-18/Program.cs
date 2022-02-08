using System;

namespace _17_18
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите значение числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 10;
            int a1 = y % 10;
            Console.WriteLine("Введите значение числа Z = ");
            int zet = Convert.ToInt32(Console.ReadLine());
            int z  = zet / 10;
            int z1 = zet % 10;
            int x = a*1000+z*100+a1*10+z1;
            Console.WriteLine("Ответ : х = " + x);
            
            Console.WriteLine("Введите значение  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 100;
            int b1 = (y1 % 100) / 10;
            int b2 = y1 % 10;
            Console.WriteLine("Введите значение числа Z = ");
            int zet1 = Convert.ToInt32(Console.ReadLine());
            int c = zet1 / 10;
            int c1 = zet1 % 10;
            int x1 = b*10000+c*1000+b1*100+c1*10+b2;
            Console.WriteLine("Ответ : х = " + x1);
        }
    }
}
