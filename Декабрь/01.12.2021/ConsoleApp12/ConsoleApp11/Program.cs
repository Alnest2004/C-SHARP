using System;

namespace ConsoleApp11
{
    class Program
    {
        struct Student
        {
            string FIO;
            string bd;
            public int grup;
            string tel;
            public void input()
            {
                Console.WriteLine("Введите ФИО");
                FIO = Console.ReadLine();
                Console.WriteLine("Введите дату рождения");
                bd = Console.ReadLine();
                Console.WriteLine("Введите номер группы");
                grup = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер телефона");
                tel = Console.ReadLine();
            }

            public void output()
            {
                Console.WriteLine("ФИО: {0}", FIO);
                Console.WriteLine("ДР: {0}", bd);
                Console.WriteLine("Группа: {0}", grup);
                Console.WriteLine("Номер телефона: {0}", tel);
            }

        }
        static void Main(string[] args)
        {
            Student[] students = new Student[4];
            for (int i = 0; i < 4; i++)
            {
                students[i].input();
            }
            Console.WriteLine("Введите проверяемую группу");
            int gruop = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                if (students[i].grup == gruop)
                {
                    students[i].output();
                }
            }

            Console.ReadKey();
        }
    }
}
