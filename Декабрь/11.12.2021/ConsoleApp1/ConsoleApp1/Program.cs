using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            char[,] a = new char[2, 2];
            Console.WriteLine("Введите несколкьо букв русского алфавита");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }
            Console.WriteLine("Введенные буквы");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   Console.Write( a[i, j]) ;
                }
            }
            Console.WriteLine("Введите cлово сотоящее из неповторяющихся букв");
            string s = Console.ReadLine();
            int d = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k=0;k<s.Length;k++)
                    {
                        if (s[k] == a[i,j])
                        {
                            d = 1;
                            s.Remove(k);
                                                       
                        }
                        else
                        {
                            d = 0;
                        }
                    }
                }
            }
            if (d == 1) Console.WriteLine("Можно");
            else Console.WriteLine("Нельзя");




        }
    }
}
