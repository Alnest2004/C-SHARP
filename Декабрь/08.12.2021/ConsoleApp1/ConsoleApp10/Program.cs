using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8 ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[] b = new int[100];
            Random rnd = new Random();
            Console.WriteLine("1-й массив ");
            for (int i = 0; i < n; i++) { a[i] = rnd.Next(1, 100); Console.Write(" " + a[i]); }
            Console.WriteLine();
            Console.WriteLine("2-й массив ");
            for (int i = 0; i < m; i++) { b[i] = rnd.Next(0, 100); Console.Write(" " + b[i]); }
            Console.WriteLine();
            Console.WriteLine("Введите к ");
            int k = int.Parse(Console.ReadLine());
            k = (k - 1);

            var c = new int[a.Length + b.Length];

            Array.Copy(a, c, k);
            Array.Copy(b, 0, c, k, b.Length);
            Array.Copy(a, k, c, b.Length + k, a.Length - k);

            Console.WriteLine();
            Console.WriteLine("Объединение массивов:");
            Console.WriteLine();
            for (int i = 0; i < c.Length; i++)
                if (c[i] != 0)
                {
                    Console.Write(" " + c[i]);
                }
            Console.ReadKey();
        }
    }
}
