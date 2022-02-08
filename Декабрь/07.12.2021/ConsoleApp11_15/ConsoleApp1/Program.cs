using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите L промежутка");
            int L = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите N промежутка");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число M");
            int M = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] A = new int[5];
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                A[i] = rnd.Next(L, N);
                Console.Write(A[i]+" ");
            }
            int K = 0;
            for (i = 0; i < 5; i++)
            {
                if (A[i] % M == 0)
                {
                    K++;
                }
            }
            Console.WriteLine("Чисел кратных М" + K);
            Console.ReadKey();


        }
    }
}

