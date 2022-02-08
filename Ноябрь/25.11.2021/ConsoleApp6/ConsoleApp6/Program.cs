using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int a1 = Convert.ToInt32(Console.ReadLine());
            double sum = a + a1;
            double pr = a1 * a;
            double razn = a1 - a;
            double ch = a / a1;
            Console.WriteLine("Сумма = " + sum + "Произведение = " + pr + "Разность = " + razn + "Частное = " + ch);

        }
    }
}
