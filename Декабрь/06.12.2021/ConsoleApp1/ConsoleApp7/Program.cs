using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] A = { 2, 1, 5, 3, 2, 5, 4 };
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                if (i == A[i])
                {
                    sum = sum + A[i];

                }

            }
            Console.WriteLine("Сумма" + sum);

        }
    }
}
