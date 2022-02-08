using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите C промежутка");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите D промежутка");
            int D = Convert.ToInt32(Console.ReadLine());

            int[] A = new int[5];
            int i;
            Console.WriteLine("Введите массив");
            for (i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Числа в промежутке ");
          
            for (i = 0; i < 5; i++)
            {
                if (A[i]<D && A[i]>C)
                {
                    Console.WriteLine(A[i]);
                }
            }
         

        }
    }
}