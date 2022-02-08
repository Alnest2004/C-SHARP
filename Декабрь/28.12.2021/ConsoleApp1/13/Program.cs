using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива ");
            Console.WriteLine("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите заданное число = ");
            int u = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            Console.WriteLine("Введите массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Исходный массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > u)
                        Console.WriteLine("Номер элемента, большего заданного числа : " + i +" - "+ j );
                }
            }
            
        }
    }
}
