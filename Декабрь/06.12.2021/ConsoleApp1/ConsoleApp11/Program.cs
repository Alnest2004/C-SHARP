using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] terms = new int[x.Length];
            int k = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 != 0)
                {
                    terms[i] = x[i];
                    k++;
                }

            }


            for (int i = 0; i < terms.Length; i++)
            {
                if (k == 0)
                {
                    Console.WriteLine("Нечётных чисел нет!");
                    break;
                }
                if (terms[i] != 0)
                {
                    Console.Write(terms[i]);
                }

            }

            Console.ReadKey();

        }
    }
}
