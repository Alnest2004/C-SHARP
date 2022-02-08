using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            string a1 = "Первый текст например. текста продолжение.";
            string a2 = "Второй текст возможно. Продолжение текста .";
            a1 = a1.ToLower();
            a2 = a2.ToLower();


            string[] aa1 = a1.Split(' ', '.');
            string[] aa2 = a2.Split(' ', '.');

            foreach (var s in aa2)
            {
                foreach (var s1 in aa1)
                {
                    if (s1 == s)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
