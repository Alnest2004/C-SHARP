using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            int size;
            Console.WriteLine("Введите размер массива : ");
            size = Convert.ToInt32(Console.ReadLine());
           
            int[] a = new int[size];
            Console.WriteLine("Введите массив : ");
           
            string str = Console.ReadLine();
            
            string[] mas = str.Split(' ');
            
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(mas[i]);
            }

            int temp;
            for (int i = 0; i < size; i++)
            {
               
                int minValueIndex = i;

              
                for (int j = i + 1; j < size; j++)
                {
                    if (a[j] > a[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }

               
                temp = a[i];
                a[i] = a[minValueIndex];
                a[minValueIndex] = temp;
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }

            Console.ReadKey();
        }
    }
}
