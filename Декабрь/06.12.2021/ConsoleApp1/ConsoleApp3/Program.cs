using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            int[] A = { 14, 4, 5, 7, 2, 9, 4 };
            int max = A[0];
            int min = A[0];
          
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
              if (A[i] > max)
                {

                 max = A[i];
                 index = i;

                }
            }
            int index1 = 0;
         
            for (int i = 0; i < 7; i++)
            {
                if (A[i] < min)
                {

                    min = A[i];
                    index1 = i;

                }
            }
            int m = 0;
            m = A[index] ;
            A[index] = A[index1];
            A[index1] = m;

            for (int i = 0; i < 7; i++)
            {
            Console.WriteLine(A[i]);
            }
        }
    }
}
