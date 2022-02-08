using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x,y");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                double z = Math.Abs(Math.Cos(Math.Pow(x, 2)) - Math.Pow(Math.Sin(y), 2)) / (Math.Pow(Math.Abs(Math.Log10(x)), 1 / 4));
                Console.WriteLine("z={0}", z);

            }
            catch (DivideByZeroException) { Console.WriteLine("Возникло исключение!"); }
            catch
            {
                Console.WriteLine("Ошибка: Неверный формат числа");
            }
        }
    }
}