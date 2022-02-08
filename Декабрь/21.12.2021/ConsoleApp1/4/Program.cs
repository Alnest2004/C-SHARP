using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 4 ");
            Console.WriteLine("Введите число N ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Делители числа N, кратные числу "+ c );
            
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    if (i % c == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
          

        }
    }
}
