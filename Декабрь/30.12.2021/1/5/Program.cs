using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 5;
            int[,] m = new int[s1, s1];
            var rnd = new Random();
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s1; j++)
                {
                    m[i, j] = rnd.Next(0, 9);

                }
            }
            Console.WriteLine("Массив : ");
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s1; j++)
                {
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine();
            }
            double s = 0;
            int k = 0;
            for (int i = s1-1 ; i > 0; i--)
            {
                for (int j = s1-1; j > s1-i-1 ; j--)
                {  
                        s += m[i, j];
                    k++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Среднее арифметическое элементов, расположенных под побочной диагональю = " + s/k );
        }
    }
}
