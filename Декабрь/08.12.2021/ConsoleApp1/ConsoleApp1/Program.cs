using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            
            int[] A = { 3,6,8,0,7,9,5,9,5,3,8,5};
            int alast = A[0];
            int k = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > alast)
                {
                    alast = A[i];
                }
                else k=k+1;
            }
            Console.WriteLine(k);
            
        }
    }
}
