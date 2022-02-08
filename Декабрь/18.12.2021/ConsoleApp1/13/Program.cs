using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Двухзначные, в которых цифры разные ");
            int i = 0;
            
                for (i = a; i < b; i++)
                {
                    if (i < 100)
                    {
                        if (i % 10 != i / 10)
                        {
                            Console.WriteLine(i);
                        }
                    }

                
            }
            
        }
    }
}
