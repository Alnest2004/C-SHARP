using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            int n, min;
            int sum = 0;
            Console.WriteLine("Введите количество элементов = ");
            int nn = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[nn];
            for (int i = 0; i < nn; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                mas[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + mas[i];
            }
            float sr = sum / nn;
            Console.WriteLine("Среднее = " + sr);

            min = mas[0];
            int j = 1;
            for (int i = 0; i < nn; i++)
            {
                if (mas[i] <= min)
                {
                    min = mas[i];
                    j = i;
                }
            }

            Console.WriteLine("Минимальное = " + min + " в позиции = " + j);
            mas[j] = (int)sr;
            for (int i = 0; i<nn; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
