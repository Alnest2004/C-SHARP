using System;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 1, num2 = 2, summarize, multiply, sub, divide = 0;
            Console.Write("Введите первое число:");
            try
            {
                num1 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }
            Console.Write("Введите второе число:");
            try
            {
                num2 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения второго числа будет 2");
            }
            summarize = num1 + num2;
            multiply = num1 * num2;
            sub = num1 - num2;
            try
            {
                divide = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!");
            }
            Console.WriteLine(
            "\n" + num1 + " + " + num2 + " = " + summarize +
            "\n" + num1 + " * " + num2 + " = " + multiply +
            "\n" + num1 + " - " + num2 + " = " + sub +
            "\n" + num1 + " / " + num2 + " = " + divide);
            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            string anykey = Console.ReadLine();

            Console.ReadKey();

        }
    }
}
