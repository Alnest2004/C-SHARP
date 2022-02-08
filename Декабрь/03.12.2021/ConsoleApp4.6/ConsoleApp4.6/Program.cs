using System;

namespace ConsoleApp3
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
            summarize = ((float)(Math.Log10(Math.Abs(Math.Pow(num1, 7)))+Math.Atan(Math.Pow(num2, 2))+(Math.PI/Math.Pow(Math.Abs(num1 + num2),(1/2)))));
            try
            {
                divide = (float)(Math.PI / (Math.Pow(Math.Abs(num1 + num2), (1 / 2))));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!");
            }
            try
            {
                if ((num1 + num2) < 0)
                {
                    throw new Exception("Получился корень из отрицательного числа!");
                }
                float kor = (float)Math.Pow(Math.Abs(num1+num2),1/2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            Console.WriteLine("Результат = "+summarize);
            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            string anykey = Console.ReadLine();

        }
    }
}
