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
            int[] x = { 1, -2, 8, 100, -9, 9, 12, -13 };
            int k = 0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                if (((x[i] <= 0) && (x[i + 1] >= 0)) || ((x[i] >= 0) && (x[i + 1] <= 0)))
                {
                    k++;
                }
            }
            Console.WriteLine("Знак меняетя" + k + "Раз");
            Console.ReadKey();


        }
    }
}
