using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp144
{
    class Program
    {
        public static int Fib(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            return Fib(n - 2) + Fib(n - 1);
        }
        static void Main(string[] args)
        {
            int[] nums = new int[11];
            int[] mas = { 1, 2, 3, 4 };
            int sum = 0;
            for (int x = 1; x < 11; x++)
            {
                nums[x] = Fib(x);
            }
            for (int x = 1; x <11; x++)
            {
                Console.Write(nums[x] + "  ");
            }
            for (int i = 1; i < mas.Length; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    if (nums[x] == i)
                    {
                        sum = sum + mas[i];
                    }
                }
            }
            Console.WriteLine("Сумма = "+sum);


            Console.ReadKey();
        }
    }
}
