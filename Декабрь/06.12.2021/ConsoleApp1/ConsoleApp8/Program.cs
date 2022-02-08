using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число банков ");
            int n = Convert.ToInt32(Console.ReadLine());
            double [] A= new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++) 
            {
                A[i] = rnd.Next(2, 3);
            }
            double
            min = A[1];
            for (int i = 0; i < n; i++)
            {
                if (A[i] < min)
                    min = A[i];
            }
            Console.WriteLine("Наименьший курс валют " + min);
        }
       
    }
}
