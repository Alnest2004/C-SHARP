using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PERSON
    {
        public string FIO;
        int god;
        public void input()
        {
            Console.Write("Введите ФИО:");
            FIO = Console.ReadLine();
            Console.Write("Введите год рождения:");
            god = Convert.ToInt32(Console.ReadLine());
        }

    }
    class PROGRAMMER : PERSON
    {
        int nomer;
        string lan;

        public void input()
        {
            base.input();
            Console.Write("Введите номер категорию:");
            nomer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите язык:");
            lan = Console.ReadLine();

        }
        public void output()
        {
            if (lan == "C#")
            {
                Console.WriteLine(FIO);

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PROGRAMMER[] programmer = new PROGRAMMER[5];

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j + 1);
                programmer[j] = new PROGRAMMER();
                programmer[j].input();
            }

            for (int i = 0; i < 5; i++)
            {
                programmer[i].output();
            }



        }
    }
}