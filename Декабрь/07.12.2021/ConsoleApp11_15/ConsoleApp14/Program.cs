using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14");
            Console.WriteLine("Введите количество элементов = ");
            int nn = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[nn];
            int[] mas2 = new int[nn];

            for (int i = 0; i < nn; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            int n1 = 0;
            Console.WriteLine("Введите k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<nn; i++)
            {
                if (mas[i] % 10 == k)
                {
                    n1++;
                    mas2[n1] = mas[i];
                } 
            }
            Console.WriteLine("Новый массив = ");
            for (int i = 1; i<=n1; i++)
            {
                Console.Write(mas2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
