using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {

        static int[,] Input(out int n)
        {
            Console.WriteLine("Размер массива ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static int[,] Rezalt(int[,] a)
        {

            if (a.GetLength(0) % 2 == 0)
            {
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        int temp = a[j, i + 1];
                        a[j, i + 1] = a[j, i];
                        a[j, i] = temp;
                    }
                    i++;
                }
                return a;
            }
            else return a;
        }

        static void Main(string[] args)
        {
            int n;
            int[,] myArray = Input(out n);
            Console.WriteLine("Исходный массив:");
            Print(myArray);
            int[,] res = new int[n, n];
            Console.WriteLine("Выходной массив:");
            res = Rezalt(myArray);
            Print(res);
        }
    }
}
