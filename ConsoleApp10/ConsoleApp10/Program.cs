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
    class LEARNER : PERSON
    {
        int nomer;
        int propusk;
        int sr;

        public void input()
        {
            base.input();
            Console.Write("Введите номер класса:");
            nomer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол. пропусков:");
            propusk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите средний балл:");
            sr = Convert.ToInt32(Console.ReadLine());
        }
        public void output()
        {
            if (propusk > 10)
            {
                Console.WriteLine(FIO);
                Console.WriteLine(nomer);

            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LEARNER[] learner = new LEARNER[2];

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine(j + 1);
                learner[j] = new LEARNER();
                learner[j].input();
            }

            for (int i = 0; i < 2; i++)
            {
                learner[i].output();
            }



        }
    }
}