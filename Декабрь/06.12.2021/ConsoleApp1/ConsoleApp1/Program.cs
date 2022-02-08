using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Ввидите К");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] A = new int [5];
            int i = 0;
            for (i = 0; i < 5; i++) {
                Console.WriteLine("Введите " + i + "-й элемент : ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (i = 0; i < 5; i++)
            {
                if (A[i] % k == 0)
                {
                    sum = sum + A[i];
                }
            }
            Console.WriteLine("Сумма" + sum);

        }
    }
}
