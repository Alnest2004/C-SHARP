using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a,b,c,n,x");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());

                double y = 5 * Math.Pow(a, n * x) / (b + c) - Math.Sqrt(Math.Abs(Math.Cos(Math.Pow(x, 3))));
                Console.WriteLine("y={0}", y);




            }
            catch (DivideByZeroException) { Console.WriteLine("Возникло исключение!"); }
            catch
            {
                Console.WriteLine("Ошибка: Неверный формат числа");
            }
            Console.ReadKey();

        }
    }
}