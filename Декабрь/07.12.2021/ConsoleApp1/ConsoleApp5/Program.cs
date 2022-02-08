using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            

            Console.WriteLine("Введите массив из 0 и 1 ");
            int[] A = new int[5];
            int[] B = new int[5];
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int K = 0;
            for (i = 0; i < 5; i++)
            {
                if (A[i] == 0)
                {
                    K++;
                }
            }
            for (i = 0; i <K; i++)
            {
                B[i] = 0;
            }
            for (i = K; i < 5; i++)
            {
                B[i] = 1;
            }
            Console.WriteLine("Выходной массив ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(B[i]);
            }
        }
    }
    
}
