using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите количество элементов = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] mass = new int[n];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(0, 30);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            int j = 1;
            while (j < n)
            {
                Console.WriteLine("Значение = {0}: Индекс = {1}", mass[j], j);
                j *= 2;
            }
            Console.ReadKey();
        }
    }
}