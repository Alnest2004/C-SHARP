using System;

namespace ConsoleApp4
{

    public struct Student
    {
        public string fio;
        public string math;
        public int fiz;
        public int inf;

        public void show()
        {
            Console.WriteLine("Имя сотрудника {0}; Должность{1}; Отдел{2}; Телефон{3}", fio, math, fiz, inf);
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Student s;
            Console.WriteLine("Введите ФИО:");
            s.fio = Console.ReadLine();
            Console.WriteLine("Должность:=");
            s.math = Console.ReadLine();
            Console.WriteLine("Отдел:=");
            s.fiz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Номер:=");
            s.inf = Convert.ToInt32(Console.ReadLine());
            s.show();

            Student[] mas = new Student[2];

            for (int i = 0; i < 2; ++i)
            {
                Console.WriteLine("Введите ФИО:");
                mas[i].fio = Console.ReadLine();
                Console.WriteLine("Должность:=");
                mas[i].math = Console.ReadLine();
                Console.WriteLine("Отдел:=");
                mas[i].fiz = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Номер:=");
                mas[i].inf = Convert.ToInt32(Console.ReadLine());
                mas[i].show();
            }
            for (int i = 0; i < 2; ++i)
            {
                if (mas[i].math == "Уборщик")
                {
                    Console.WriteLine(mas[i].fio);
                }
            }

        }
    }
}