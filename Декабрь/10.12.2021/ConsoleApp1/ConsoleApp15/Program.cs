using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.WriteLine("Введите строку A, например 'ИНТЕГРАЛ'");
            string A = Console.ReadLine();
            Console.WriteLine("Введите строку B, например 'ГРАНТ'");
            string B = Console.ReadLine();
            StringBuilder str1 = new StringBuilder(A);
            StringBuilder str2 = new StringBuilder(B);

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        str1[i] = ' ';
                        str2[j] = ' ';
                    }
                }
            }
            for (int j = 0; j < B.Length; j++)
            {
                str2 = str2.Replace(" ", "");
            }

            if (str2.Length == 0)
            {
                Console.WriteLine("МОЖНО СОСТАВИТЬ СЛОВО!");
            }
            else
            {
                Console.WriteLine("Нельзя!");
            }
            Console.ReadKey();
        }
    }
}
