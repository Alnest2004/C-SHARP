using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите количество человек");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int k = 0;
            int k1= 0;
            int k2 = 0;
            int k3 = 0;
            int k4 = 0;
            int k5 = 0;
            int k6 = 0;
            int k7 = 0;
            int k8 = 0;
            int k9 = 0;

            for (int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (0 < A[i] && A[i] < 10)
                    k++;
                if (10 < A[i] && A[i] < 20)
                    k1++;
                if (20 < A[i] && A[i] < 30)
                    k2++;
                if (30 < A[i] && A[i] < 40)
                    k3++;
                if (40 < A[i] && A[i] < 50)
                    k4++;
                if (50 < A[i] && A[i] < 60)
                    k5++;
                if (60 < A[i] && A[i] < 70)
                    k6++;
                if (70 < A[i] && A[i] < 80)
                    k7++;
                if (80 < A[i] && A[i] < 90)
                    k8++;
                if (90 < A[i] && A[i] < 100)
                    k9++;
            }
            Console.WriteLine("0-10 =" + k + "  10-20= " + k1 + "  20-30 = " + k2+ "  30-40=  " + k3+ "  40-50=" + k4+ "  50-60= " + k5+ "  60-70= " + k6+ "  70-80= " + k7+ "  80-90= " + k8+ "  90-100=   " + k9);



        }
    }
    }


