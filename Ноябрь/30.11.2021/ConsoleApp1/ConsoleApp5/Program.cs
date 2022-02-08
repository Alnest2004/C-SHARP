using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int pol = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random() ;
                int r = rnd.Next();
            while (pol>0)
            {
                int c = pol % 10;
                pol = pol / 10;
                if (c == r)
                    Console.WriteLine("Cовпадения есть");
                else Console.WriteLine("Cовпадений нет");
            }

        }
    }
}
