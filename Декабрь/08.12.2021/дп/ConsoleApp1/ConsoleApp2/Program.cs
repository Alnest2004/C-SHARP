using System;
// Второе задание: посчитать возраст n человек

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество человек");
            int n = int.Parse(Console.ReadLine());
            int o = 1;
            int mel = 0;
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            int m5 = 0;
            int m6 = 0;
            int m7 = 0;
            int m8 = 0;
            int m9 = 0;
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Введите возраст человека под номером " +o);
                int chel=int.Parse(Console.ReadLine());
                o += 1;
                if (chel <= 9)
                {
                    mel += 1;
                 
                }
                if (chel <= 19 && chel >=10)
                {
                    m1 += 1;

                }
                if (chel <= 29 && chel >= 20)
                {
                    m2 += 1;

                }
                if (chel <= 39 && chel >= 30)
                {
                    m3 += 1;

                }
                if (chel <= 49 && chel >= 40)
                {
                    m4 += 1;

                }
                if (chel <= 59 && chel >= 50)
                {
                    m5 += 1;

                }
                if (chel <= 69 && chel >= 60)
                {
                    m6 += 1;

                }
                if (chel <= 79 && chel >= 70)
                {
                    m7 += 1;

                }
                if (chel <= 89 && chel >= 80)
                {
                    m8 += 1;

                }
                if (chel <= 99 && chel >= 90)
                {
                    m9 += 1;

                }
            }
            Console.WriteLine("Количество людей в возрасте от 0 до 9: " + mel);
            Console.WriteLine("Количество людей в возрасте от 10 до 19: " + m1);
            Console.WriteLine("Количество людей в возрасте от 20 до 29: " + m2);
            Console.WriteLine("Количество людей в возрасте от 30 до 39: " + m3);
            Console.WriteLine("Количество людей в возрасте от 40 до 49: " + m4);
            Console.WriteLine("Количество людей в возрасте от 50 до 59: " + m5);
            Console.WriteLine("Количество людей в возрасте от 60 до 69: " + m6);
            Console.WriteLine("Количество людей в возрасте от 70 до 79: " + m7);
            Console.WriteLine("Количество людей в возрасте от 80 до 89: " + m8);
            Console.WriteLine("Количество людей в возрасте от 90 до 99: " + m9);



        }
    }
}
