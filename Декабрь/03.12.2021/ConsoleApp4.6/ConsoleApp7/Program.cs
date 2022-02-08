using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            int z = 1;
            double m = 0;
            Console.Write("Введите x:");
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }
            Console.Write("Введите y:");
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }
            Console.Write("Введите z:");
            try
            {
                z = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }


            try
            {
                m = (x + y) / (x - 0.5) - (x - z) / x * y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!");
            }


            Console.WriteLine("Ответ : " + m);

            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            string anykey = Console.ReadLine();

            Console.ReadKey();

        }
    }
}
