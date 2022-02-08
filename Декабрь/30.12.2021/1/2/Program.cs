using System;

namespace _2
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
                    m[i, j] = rnd.Next(1, 9);

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
            int k = 0;
            double s = 0;
            for (int i = s1-1; i > 0; i--)
            {
                for (int j = i-1 ; j >= 0; j--)
                {
                    if (m[i, j] % 2 == 0)
                    {
                        k++;
                        s += m[i, j];
                    }
                }
                Console.WriteLine();
            }
            if (k != 0)
                Console.WriteLine("Среднее ариметическое четных элементов, находящихся ниже главной диагонали = " + s / k);
        }
    }
}
