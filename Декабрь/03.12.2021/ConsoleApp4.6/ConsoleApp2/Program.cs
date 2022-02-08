using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x,y");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double z = 3*Math.Pow(Math.Cos(x - Math.PI / 6), 2) / (0.5 + Math.Sin(Math.Pow(y, 2)));
                Console.WriteLine("z={0}", z);

            }

            catch
            {
                Console.WriteLine("Ошибка: Неверный формат числа");
            }

            Console.ReadKey();
        }
    }
}