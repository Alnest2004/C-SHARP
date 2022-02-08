using System;
using System.Collections.Generic;
// chetire

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B = ");
            int b = Convert.ToInt32(Console.ReadLine());
          
            for (int i = a; i < b; i++)
            {
                int sum = 0;
                int n = i;
                while (n != 0)
                {
                    int k;
                    k = n % 10;
                    if (k % 2 != 0)
                        sum = sum + k;
                    n = n / 10;
                }
                Console.WriteLine("Сумма нечетных цифр числа " + i + " равна " + sum);

            }
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите значение C  ");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                int sum = 0;
                int n = i;
                while (n != 0)
                {
                    int k;
                    k = n % 10;
                    if (k % 2 != 0) 
                        sum = sum + k;
                    n = n / 10;
                }
                if (sum == c)
                    Console.WriteLine("Сумма нечетных цифр числа " + i + " равна " + sum);
            }
            Console.WriteLine("Задание 3");
            
            for (int i = a; i < b; i++)
            {
                int sum = 0;
                int n = i;
                while (n != 0)
                {
                    int k;
                    k = n % 10;
                    if (k % 2 != 0)
                    sum = sum + k;
                    n = n / 10;
                }
                if (sum == 2 || sum == 3 || sum % 2 != 0 && sum % 3 == 0)
                    Console.WriteLine("Сумма нечетных цифр числа "+ i +" является простым числом ") ;
            }


                Console.WriteLine("Задание 4");
            Console.WriteLine("Введите значение А ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int sum3 = 0;
            while (a1 != 0)
            {
                int k;
                k = a1 % 10;
                if (k % 2 != 0)
                    sum3 = sum3 + k;
                a1 = a1 / 10;
            }
            for (int i = a1; i < b; i++)
            {
                int sum34 = 0;
                int n = i;
                while (n != 0)
                {
                    int k;
                    k = n % 10;
                    if (k % 2 != 0)
                        sum34 = sum34 + k;
                    n = n / 10;
                }
                if (sum34 == sum3)
                    Console.WriteLine("Число с такой же  суммой нечетных цифр числа как и A  = "+i);
            }


        }

        public static int getSum(int a)
        {
            a = Math.Abs(a);
            int val = a % 10;
            if (a / 100 != 0) val += getSum(a / 100);
            return val;
        }
        public static void getSearch(int a, int next_min, int next_max, ref int[] val)
        {
            bool done = false;
            if (getSum(next_min) == getSum(a)) { val[0] = next_min; done = true; }
            if (getSum(next_max) == getSum(a)) { val[1] = next_max; done = true; }
            if (!done) getSearch(a, next_min - 1, next_max + 1, ref val);
        }
      
    }
}
