using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент, кроме 0!", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                k++;
                if (k == 2)
                {
                    a[i] = 0;
                    k = 0;
                }
            }
            Console.WriteLine("Полученный массив : ");
            
            for (int i = 0; i < n; i++)
            {
                if (a[i] != 0)
                {
                    Console.Write(a[i]+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
