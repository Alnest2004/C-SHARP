using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число!");
            int chislo = Convert.ToInt32(Console.ReadLine());
            int s = (chislo % 10)*((chislo / 10) % 10)*((chislo / 100 ) % 10) * (chislo / 1000);
            Console.WriteLine("Произведение цифр равно = "+ s);

        }
    }
}
