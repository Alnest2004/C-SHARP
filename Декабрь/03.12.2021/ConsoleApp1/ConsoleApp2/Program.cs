using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 1;
            double a = 1;
            double c = 1;
            double x = 0;
            Console.Write("Введите b:");
            try
            {
                b = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }
            Console.Write("Введите a:");
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }
            Console.Write("Введите c:");
            try
            {
                c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }


            try
            {
                x = ((-1)*b+Math.Sqrt(b*b)-4*a*c)/(2*a);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!");
            }

            try
            {
                if ((b * b) - 4 * a * c < 0)
                {
                    Console.WriteLine("Число не должно быть отрицательным");
                }
                x = ((-1) * b + Math.Sqrt(b * b) - 4 * a * c) / (2 * a);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка:{e.Message }");
            }
            Console.WriteLine("Ответ : " + x);

            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            string anykey = Console.ReadLine();

            Console.ReadKey();

        }
    }
}