using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3");
            string[] b = { "Maxim", "Vladislav", "Viktor", "Viniamin", "Evgen"};
            int[] ochenka = new int[b.Length];
            int kol = 0;
            for(int i=0; i<b.Length; i++)
            {
                Console.WriteLine("Введите оценку для " + b[i]);
                ochenka[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < b.Length; i++)
            {
                if (ochenka[i] == 5)
                {
                    kol++;
                }

            }
            Console.WriteLine("Количество абитуриентов сдавших на отлично = " + kol);
            Console.ReadKey();
        }
    }
}
