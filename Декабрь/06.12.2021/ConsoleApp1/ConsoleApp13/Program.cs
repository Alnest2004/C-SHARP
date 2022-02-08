using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, -2, 8, 100, -9, 0, 12, -13 };
            int nul = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                {
                    nul = i;
                }
            }
            for (int i = 0; i < nul; i++)
            {
                Console.Write(x[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
