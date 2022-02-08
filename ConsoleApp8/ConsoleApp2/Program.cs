using System;
using System.Collections;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Введите число которое хотите добавить");
            int ch = Convert.ToInt32(Console.ReadLine());
            list.Add(ch);
            foreach (int i in list)
            {
                Console.Write(i + " \t");
            }
            Console.WriteLine();
            Console.WriteLine("Напишите число которе хотите удалить");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            list.Remove(ch1);
            foreach (int i in list)
            {
                Console.Write(i + " \t");
            }
            Console.WriteLine();
            Console.WriteLine("Введите заданное значение для поиска");
            int ch2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            foreach (int i in list)
            {
                if (i == ch2)
                {
                    Console.WriteLine("Найденное число = " + i);
                }
            }

            Console.ReadKey();
        }
    }
}
