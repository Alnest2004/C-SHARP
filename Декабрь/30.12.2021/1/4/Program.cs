using System;

namespace _4
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
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s1; j++)
                {
                    if ((i + j) < (s1 + 1) && m[i, j] != 0)
                    {
                        s += m[i, j];
                        k++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Среднее арифметическое ненулевых элементов, расположенных над побочной диагональю = " + s / k);
        }
    }
}
