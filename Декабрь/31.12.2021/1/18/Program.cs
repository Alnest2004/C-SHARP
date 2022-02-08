using System;

namespace zadanie18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива :");
            int n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int count = 0, sum = 0, count1 = 0;
            int[,] arr = new int[n, n];
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(1, 10);
                    Console.Write($"" + arr[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j, i] == arr[j + 1, i])
                    {
                        count += j;
                        break;
                    }
                }
                arr1[i] = count;
                Console.WriteLine(count);
                count = 0;
            }
        }
    }
}
