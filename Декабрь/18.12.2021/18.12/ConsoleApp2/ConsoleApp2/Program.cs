using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите А:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                if (i % 2 == 0) Console.WriteLine($"Квадрат {i} = {i * i}");
            }

            Console.ReadKey();
        }
    }
}
