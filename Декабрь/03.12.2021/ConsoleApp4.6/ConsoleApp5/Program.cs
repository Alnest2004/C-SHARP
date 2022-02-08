using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1 = 1, num2 = 2, num3=3 ,num4=4 ,num5=5 , summarize, multiply, sub, divide = 0;
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
            Console.Write("Введите третье число:");
            try
            {
                num3 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения второго числа будет 2");
            }
            Console.Write("Введите четвёртое число:");
            try
            {
                num4 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения второго числа будет 2");
            }
            Console.Write("Введите пятое число:");
            try
            {
                num5 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения второго числа будет 2");
            }
            summarize = (float)(Math.Pow(Math.Pow(num1+num2,2)/(num3+num4),1/4)+Math.Pow(Math.E,Math.Pow(num5+1,1/2)));
            try
            {
                divide = (float)(Math.Pow(num1 + num2, 2) / (num3 + num4));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!");
            }
            try
            {
                if ((Math.Pow(num1 + num2, 2) / (num3 + num4)) < 0)
                {
                    throw new Exception("Получился корень из отрицательного числа!");
                }
                float kor = (float)Math.Pow(Math.Abs(num1 + num2), 1 / 2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            Console.WriteLine("Результат = " + summarize);
            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            string anykey = Console.ReadLine();
        }
    }
}
