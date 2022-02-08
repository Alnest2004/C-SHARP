using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static bool IsDiff(int N)
        {
            int[] arr = new int[N.ToString().Length];
            int j = 0;
            while (N != 0)
            {
                arr[j] = N % 10;
                j++;
                N /= 10;
            }
            Array.Sort(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            while (a <= b)
            {
                if (IsDiff(a)) Console.Write($"{a} ");
                a++;
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}