using System;

namespace ConsoleApp4
{

    public struct Student
    {
        public string fio;
        public int math;
        public int fiz;
        public int inf;

        public void show()
        {
            Console.WriteLine("Имя студента {0}; Математика{1}; Физика{2}; Информатика{3}", fio, math, fiz, inf);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Student s;
            Console.WriteLine("Введите ФИО:");
            s.fio = Console.ReadLine();
            Console.WriteLine("Математика:=");
            s.math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Физика:=");
            s.fiz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Информатика:=");
            s.inf = Convert.ToInt32(Console.ReadLine());
            s.show();

            Student[] mas = new Student[2];

            for (int i = 0; i < 2; ++i)
            {
                Console.WriteLine("Введите ФИО:");
                mas[i].fio = Console.ReadLine();
                Console.WriteLine("Математика:=");
                mas[i].math = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Физика:=");
                mas[i].fiz = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Информатика:=");
                mas[i].inf = Convert.ToInt32(Console.ReadLine());
                mas[i].show();
            }
            for (int i = 0; i < 2; ++i)
            {
                if ((mas[i].math > 4) && (mas[i].fiz > 4) && (mas[i].inf > 4))
                {
                    Console.WriteLine(mas[i].fio);
                }
            }

        }
    }
}