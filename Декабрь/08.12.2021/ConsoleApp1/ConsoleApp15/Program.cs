using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            int n = 0;
            int[] mas = { 0, -1, 2, 3, 12, -32, 0, -7, 0, -21, 43, 12 };
            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[0] != mas[i])
                {
                    n += 1;
                }
            }
            Console.WriteLine("Колиичество различных элементов в последовательности: " + n);
        }
    }
}
