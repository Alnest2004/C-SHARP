using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    delegate void Sum(int number);
    class Program
    {
        static void Main()
        {
            int result;
            Random r = new Random();
            int sum = 0;
            // Вызов анонимного метода
            Sum del = delegate (int number)
            {
                for (int i = 0; i <= number; i++)
                {
                    result = r.Next(0, 101);
                    if (result % 2 == 0)
                    {
                        sum += result;
                    }
                }
                Console.WriteLine("Сумма: {0}", sum);
            };
            del(12);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
