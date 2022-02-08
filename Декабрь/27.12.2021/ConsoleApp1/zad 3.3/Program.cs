using System;

namespace zad_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a и b, d и c ");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат выражения =   " );
            int rez =  (a * Kol(b,c) / b) +  d ;
            Console.Write(rez + "/");
            int rez2 = Kol(b, c);
            Console.Write(rez2);
        }
        static int Kol(int b, int c )
        {
            int max = 0;
            for (int i = 1; i <= c; i++)
            {
                if (i%b == 0 && i%c==0)
                {
                    max = i;
                }
            }

            return max;
        }
    }
}
