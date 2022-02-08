using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            int[] A = { 14, 4, 5, 7 , 2, 9, 4};
            int[] B= new int [7];
            int i = 0;
          
            for (i = 0; i < 5; i++)
            {
                if (A[i] % 2 == 0)
                {
                    B[i] = A[i];
                }
               
            }
           
            for (i = 0; i < 5; i++)
            {
                if (B[i] == null)
                {
                    Console.WriteLine("Таких значений нет");
                }
            }
            
            for (i = 0; i < 5; i++)
            {
                if (B[i]!=0)
                    Console.WriteLine( B[i]);
            }
        }
    }
}
