using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1; 
            double y = 0;
            Console.Write("Введите первое число:");
            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат числа!\n" + "В качестве значения первого числа будет 1");
            }
          
           
            try
            {
               y = Math.Pow(Math.Abs(Math.Pow(Math.Sin(x),2)),1/2) /  ((3.1*x)-Math.Pow(Math.Exp(2.89),2*x));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на нуль!");
            }

            try
            {
                if (Math.Pow(Math.Sin(x), 2) < 0) {
                    Console.WriteLine("Число не должно быть отрицательным");
                }
                y = Math.Pow(Math.Abs(Math.Pow(Math.Sin(x), 2)), 1 / 2) / ((3.1 * x) - Math.Pow(Math.Exp(2.89), 2 * x));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка:{e.Message }") ;
            }
            Console.WriteLine("Ответ : "+ y );

            Console.Write("\nДля выхода из программы нажмите [Enter]:");
            string anykey = Console.ReadLine();

            Console.ReadKey();

        }
    }
}
