using System;

namespace ConsoleApp9 { 
 
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Задание 10 ");
            Console.Write("Введите кол-во элементов массива: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("a[{0}] = ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (a[j] > a[j + 1])
                        {
                            int b = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = b;
                        }
                    }
                }
                Console.Write("Отсортированный массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", a[i]);
                }
                Console.WriteLine();
            }
        }
    }

    
