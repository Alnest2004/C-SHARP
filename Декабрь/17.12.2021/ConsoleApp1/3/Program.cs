using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер карты: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 6:
                    Console.WriteLine("шестерка");
                    break;

                case 7:
                    Console.WriteLine("семерка");
                    break;

                case 8:
                    Console.WriteLine("восьмерка");
                    break;

                case 9:
                    Console.WriteLine("девятка");
                    break;

                case 10:
                    Console.WriteLine("десятка");
                    break;

                case 11:
                    Console.WriteLine("валет");
                    break;

                case 12:
                    Console.WriteLine("дама");
                    break;

                case 13:
                    Console.WriteLine("король");
                    break;

                case 14:
                    Console.WriteLine("туз");
                    break;

            }
            Console.ReadKey();
        }
    }
}
