using System;

namespace _15_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" четырехзначное число ");
            Console.WriteLine("Введите значение  числа Y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int a = y / 10;
            int a1 = y % 10;
            Console.WriteLine("Введите значение  числа Y = ");
            int z = Convert.ToInt32(Console.ReadLine());
            int z1 = z / 10;
            int z2 = z % 10;
            int x = a * 1000 + z1 * 100 + z2 * 10 + a1;

            Console.WriteLine("Ответ : х = " + x);
            Console.WriteLine(" пятизначное  число ");
            Console.WriteLine("Введите значение  числа Y = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение  числа Z = ");
            int zet = Convert.ToInt32(Console.ReadLine());
            int b = y1 / 10;
            int b1 = y1 % 10;
            int zt = zet / 100;
            int zt1 = (zet %100) / 10;
            int zt2 = zet % 10;
            int x1 = b * 10000 + zt * 1000 + zt1 * 100 + zt2 * 10 + b1;
            Console.WriteLine("Ответ : х = " + x1);
        }
    }
}
