using System;
// Пятое задание, тута две последовательности и в них надо было найти одинаковые числа. :c
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в первой последовательности: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int i = 0;
            int k=0;
            for (i = 0; i < n; i++)
            {
                k++;
                Console.WriteLine("Введите " + k + " й элемент : ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Введите количество элементов во второй последовательности: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] B = new int[n2];
            int u = 0;
            int d = 0;
            for (u = 0; u < n2; u++)
            {
                d++;
                Console.WriteLine("Введите " + d + " й элемент : ");
                B[u] = int.Parse(Console.ReadLine());
            }
            Console.Write("Первая последовательность: ");
            for (int s = 0; s < A.Length; s++)
            {
                Console.Write(A[s] + " ");
            }
            Console.WriteLine();
            Console.Write("Вторая последовательность: ");
            for (int f = 0; f < B.Length; f++)
            {
                Console.Write(B[f] + " ");
            }
            int kol = 0;
            int fg = 0;
            for (int v = 0; v < A.Length; v++)
            {


                for (int y = 0; y < A.Length; y++)
                {
                    if (A[v] == B[y])
                    {
                        kol += 1;
                        fg++;
                    }



                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество одинаковых значений в двух последовательностях "+kol);
        }
    }
}






































