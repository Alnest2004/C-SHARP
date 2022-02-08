using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("Начальный массив");
            for (int i = 0; i < x.Length; i++)
            {

                Console.Write(x[i] + " ");
            }
            for (int i = 0; i < x.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    int rok = x[i];
                    x[i] = x[i + 1];
                    x[i + 1] = rok;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Конечный массив");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
