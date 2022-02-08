using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            int kol = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == ':')
                {
                    kol++;
                }
            }
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == ':')
                {
                    stroka = stroka.Replace(':', ';');
                }
            }
            Console.WriteLine("Итоговая строка = " + stroka);
            Console.WriteLine("Количество замен = " + kol);
            Console.ReadKey();
        }
    }
}
