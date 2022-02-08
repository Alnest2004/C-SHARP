using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");

            Console.WriteLine("Введите M");
            int M = Convert.ToInt32(Console.ReadLine());

            int pr = 1;
            int[] A = new int[5];
            int i;
            Console.WriteLine("Введите массив");
            for (i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
           

            for (i = 0; i < 5; i++)
            {
                if (A[i] > M)
                {
                    pr = pr * A[i];
                }
            }
            Console.WriteLine("Произведение "+ pr);
        }
    }
}
