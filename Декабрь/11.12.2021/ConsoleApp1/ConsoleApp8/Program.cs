using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите текст");

            string[] words = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите количество = ");
            int k = Convert.ToInt32(Console.ReadLine());
            string uniqueWords = "";
            int kk = 0;
            foreach (var word in words)
            {
                if (!uniqueWords.Contains(word))
                {
                    uniqueWords += " " + word;
                }
            }
            Console.WriteLine("Result: {0}", uniqueWords);
            Console.ReadLine();
        }
    }
}
