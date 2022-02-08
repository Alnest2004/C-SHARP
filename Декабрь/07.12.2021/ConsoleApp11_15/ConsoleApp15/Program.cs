using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
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
            int max = a[0];
            int min = a[0];
            int sum = 0;
            int idmax = 0;
            int idmin = 0;

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1,100);
                Console.Write(a[i]+" ");
            }

            for (int i = 0; i < n; i++)
            {

                if (a[i] >= max)
                {
                    max = a[i];
                    idmax = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] <= min)
                {
                    Console.WriteLine("РАБОТАЕТ");
                    min = a[i];
                    idmin = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Минимально id = " + idmin+" мин число "+min);
            Console.WriteLine("Максимальное id = " + idmax);


            for (int i = idmax; i <= idmin; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Сумма между максимальным и минимальным = " + sum);
            Console.ReadKey();

        }
    }
}
