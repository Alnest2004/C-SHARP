using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            Random rnd = new Random();
            int max;
            int temp = 0;
            int n = Int32.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(-100, 100);
                Console.Write(mas[i] + " ");
            }
            max = mas[0];
            for (int i = 1; i < n; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                    temp = i;
                }
                if (i == n - 1)
                {
                    mas[temp] = 0;
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
