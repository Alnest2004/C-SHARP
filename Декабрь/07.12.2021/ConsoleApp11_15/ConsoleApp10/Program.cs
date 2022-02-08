using System;
using System.Linq;

namespace Zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int max = 0;
            var array = new int[N];
            Console.Write("\n");
            var random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                arr[array[i]]++;
                if (max < arr[array[i]]) max = arr[array[i]];
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine("\n\r");
            for (int i = 0; i <= 9; i++)
                if (arr[i] == max)
                { Console.Write("Число " + i + " встречается " + max + " раз"); break; }

            Console.ReadKey();
        }
    }
}