using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            double sum = Convert.ToInt32(Console.ReadLine());
            if (sum < 100) 
            { sum = sum + sum * 0.05;
                Console.WriteLine("Полученная сумма:"+sum); 
            }
            else
            {
                if (sum == 100 | sum > 100 && sum < 200)
                {
                    sum = sum + sum * 0.07;
                    Console.WriteLine("Полученная сумма:" + sum);
                }
                else
                {
                    if (sum > 200)
                    {
                        sum = sum + sum * 0.1;
                        Console.WriteLine("Полученная сумма:" + sum);
                    }
                }
            }

        }
    }
}
