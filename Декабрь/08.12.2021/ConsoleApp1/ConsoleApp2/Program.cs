using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            int[] A = { 1,2,3,4,5,6,7,8 };
            int[] B= new int [8];
            int[] B1 = new int[8];
            int[] C = new int[8];
            for (int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i];
            }
            double sr = sum / A.Length;
            int k = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]  > sr)
                {
                    B[i] = A[i];
                } 
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < sr)
                {
                    B1[i] = A[i];
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if(B[i]!=0)
                Console.WriteLine(B[i]);
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (B1[i] != 0)
                    Console.WriteLine(B1[i]);
            }

        }
    }
}
