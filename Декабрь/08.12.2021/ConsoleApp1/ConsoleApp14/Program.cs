using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            int n = 0;
            int j = 0, temp;
            int[] mas = { 0, -1, 2, 3, 12, -32, 23, -7, 123, -21, 43 };
            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    j++;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Конечный массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}
