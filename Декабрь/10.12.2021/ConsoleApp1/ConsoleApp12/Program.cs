using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            int kol1 = 0;
            int kol2 = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == '(')
                {
                    kol1++;
                }
                if (stroka[i] == ')')
                {
                    kol2++;
                }
            }
            if (kol1 == kol2)
            {
                Console.WriteLine("ЧИСЛО СКОБОК ОДИНАКОВОЕ КОЛИЧЕСТВО");
            }
            else
            {
                Console.WriteLine("Количество скобок не равны");
            }
            Console.ReadKey();
        }
    }
}
