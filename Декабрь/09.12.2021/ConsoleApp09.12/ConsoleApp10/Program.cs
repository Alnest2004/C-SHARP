using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите строку = ");
            string str = Console.ReadLine();
            int count = 0;
            int i = str.Length - 1;
            while ((i > 0) & (str[i] != ' ')) if (str[i--] == 'k') count++;


            Console.WriteLine("Количество k в последнем слове: " + count);

            Console.ReadKey();
        }
    }
}
