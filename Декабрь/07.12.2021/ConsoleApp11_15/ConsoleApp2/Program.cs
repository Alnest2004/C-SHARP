using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");


            int[] A = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            int nec = 0;
            for (i = 0; i < 5; i++)
            {
                if (A[i] % 2 != 0)
                {
                    nec++;
                }
            }
            int o = nec * 100 / 5;
            Console.WriteLine("нечетных   " + o + "%");
            Console.ReadKey();

        }
    }
}
