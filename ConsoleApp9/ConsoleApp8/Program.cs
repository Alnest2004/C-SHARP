using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    delegate void OpStroke(ref int[] arr);
    class ArrOperation
    {
        public static void WriteArray(ref int[] arr)
        {
            Console.WriteLine("Исходный массив: ");
            foreach (int i in arr)
                Console.Write("{0}\t", i);
            Console.WriteLine();
        }

        public static void vvod(ref int[] arr)
        {
            Console.WriteLine("Ввод массива");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }


        // Сортировка массива
        public static void summ(ref int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] > 0) && (i % 2 == 0))
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Сумма" + " " + sum);
        }

        public static void reverse(ref int[] arr)
        {
            Console.WriteLine("Отсортированный массив:");
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void One(ref int[] arr)
        {
            Console.WriteLine("нечётные на чётные:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[i] = arr[i] + 1;
                }
                Console.WriteLine(arr[i]);
            }

        }

        public static void Two(ref int[] arr)
        {
            Console.WriteLine("чётные на нечётные:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = arr[i] - 1;
                }
                Console.WriteLine(arr[i]);
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[6];
            ArrOperation a = new ArrOperation();
            OpStroke laba;


            laba = ArrOperation.vvod;
            laba(ref myArr);
            laba = ArrOperation.WriteArray;
            laba(ref myArr);
            laba = ArrOperation.summ;
            laba(ref myArr);
            laba = ArrOperation.reverse;
            laba(ref myArr);
            laba = ArrOperation.One;
            laba(ref myArr);
            laba = ArrOperation.Two;
            laba(ref myArr);
            Console.ReadKey();
        }
    }
}