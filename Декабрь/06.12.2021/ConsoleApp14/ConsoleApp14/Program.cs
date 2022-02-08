using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 0, -2, 8, 100, -9, 0, 12, -13 };
            for (int k = 0; k < x.Length; k++)
            {
                if (x[k] == 0) continue;
                if (x[k] > 0)
                {
                    Console.WriteLine("Первое число положительное");
                    break;
                }
                if (x[k] < 0)
                {
                    Console.WriteLine("Первое число Отрицательное");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
