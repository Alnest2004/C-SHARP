using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp155
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 15");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();
            Console.WriteLine("Новый массив рандомных значений = ");
            int min=0, max=0, sum=0;
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.Write(a[i] + " ");
            }
            for (int i=1; i>n; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
                if (a[i] > a[max])
                {
                    max = i;
                }
            }
            for (int i = min; i > max; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Сумма = " + sum);
            Console.ReadKey();
        }
    }
}
