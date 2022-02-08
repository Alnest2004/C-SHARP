using System;

namespace _9
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 8");
            double rez = 0;
            var num = new double[] { 6, 13, 21 };
            for (int i =0; i< num.Length; i++)
            {
                rez += Calculate(num[i]) / 2;
            }
            Console.WriteLine(rez);
            Console.ReadKey();
            static double  Calculate (double n)
            {
                return Math.Sqrt(n) + n;
            }
            
        }
    }
}
