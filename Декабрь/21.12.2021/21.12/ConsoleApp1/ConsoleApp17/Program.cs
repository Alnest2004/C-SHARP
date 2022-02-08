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
            Console.WriteLine("Задание 17");
            Console.WriteLine("Введите начало и конец отрезка [a,b]");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            Console.Write("Введите ровно k цифр=");
            int kk = int.Parse(Console.ReadLine());
            Console.WriteLine("Числа у которых ровно k");
            for (int i = a; i <= b; i++)
            {
                k = 0;
                int j = i;
                while ( j> 0)
                {
                    if (j % 10 % 2 == 0)
                        k++;
                    j/= 10;
                }
                if (kk == k)
                {
                    Console.Write(i + "  ");
                }
            }

            Console.ReadKey();
        }
    }
}
