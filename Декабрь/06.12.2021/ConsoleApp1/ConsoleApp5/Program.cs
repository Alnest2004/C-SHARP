using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите K");
            int[] A = { 2, 4, 5, 5, 2, 5, 4 };
            int K = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            int s = 0;
            int d = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i] < K)
                {
                    m++;
                    
                }
                if (A[i] == K)
                {
                    d++;
                   
                }
                if (A[i] > K)
                {
                   s++ ;
                   
                }
               
            }
            Console.WriteLine("Чисел меньше " + m);
            Console.WriteLine("Чисел равно  " + d);
            Console.WriteLine("Чисел больше " + s);
        }
    }
}
