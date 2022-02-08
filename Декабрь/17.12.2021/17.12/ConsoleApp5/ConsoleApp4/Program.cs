using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите номер масти :");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите порядковый номер карты: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 6:
                    Console.Write("шестерка ");
                    break;

                case 7:
                    Console.Write("семерка ");
                    break;

                case 8:
                    Console.Write("восьмерка ");
                    break;

                case 9:
                    Console.Write("девятка ");
                    break;

                case 10:
                    Console.Write("десятка ");
                    break;

                case 11:
                    Console.Write("валет ");
                    break;

                case 12:
                    Console.Write("дама ");
                    break;

                case 13:
                    Console.Write("король  ");
                    break;

                case 14:
                    Console.Write("туз  ");
                    break;

            }

            switch (m)
            {
                case 1:
                    Console.Write("пики");
                    break;

                case 2:
                    Console.Write("трефы");
                    break;

                case 3:
                    Console.Write("бубны");
                    break;

                case 4:
                    Console.Write("черви");
                    break;
            }
            Console.ReadKey();
        }
    }
}
