using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите количество элементов = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int k=0, kk=0;
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] maschet = new int[n];
            int[] masnechet = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    maschet[i] = mas[i];
                }
                else
                {
                    masnechet[i] = mas[i];
                }
            }
            Console.WriteLine("Массив из чётных элементов = ");
            for (int i = 0; i < n; i++)
            {
                if (maschet[i] != 0)
                {
                    Console.Write(maschet[i] + " ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Массив из не чётных элементов = ");
            for (int i = 0; i < n; i++)
            {
                if (masnechet[i] != 0)
                {
                    Console.Write(masnechet[i] + " ");
                }
                    
            }
            Console.ReadKey();

        }
    }
}
