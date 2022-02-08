using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            int[] A = { 2, 4, 5, 5, 2, 5, 4 };
            int sum = A[3];
            for (int i = 0; i < 7; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    sum = sum + A[i];

                }

            }
            Console.WriteLine("Сумма" + sum);

        }
    }
}
