using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            int L = stroka.Length;
            StringBuilder str = new StringBuilder(stroka);
            for (int i = 0; i < L / 2; i++)
            {
                if (stroka[i] == ':')
                {
                    str[i] = '.';
                }
            }
            for (int i = L / 2; i < L; i++)
            {
                if (stroka[i] == '!')
                {
                    str[i] = '.';
                }
            }
            Console.WriteLine("Преобразованная строка = " + str);
            Console.ReadKey();

        }
    }
}
