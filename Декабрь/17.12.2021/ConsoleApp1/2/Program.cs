using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер масти: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Пики");
                    break;

                case 2:
                    Console.WriteLine("Трефы");
                    break;

                case 3:
                    Console.WriteLine("Бубны");
                    break;

                case 4:
                    Console.WriteLine("Червы");
                    break;
            }
            Console.ReadKey();
        }
    }
}
