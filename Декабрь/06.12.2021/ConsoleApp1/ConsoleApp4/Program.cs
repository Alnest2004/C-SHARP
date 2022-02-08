using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 7");
            int[] A = { 2, 4, 5, 5, 2, 5, 4 };
            int k = 0;
            for (int i = 0; i < 7; i++)
            {
                if (A[i] ==2)
                {
                    k++;
                   
                }

            }
            Console.WriteLine("Человек не прошло :" + k);
        }
    }
}
