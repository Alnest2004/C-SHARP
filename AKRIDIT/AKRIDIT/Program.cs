using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKRIDIT
{
    struct Student
    {
        public string Fio, god, number;
        public int group;

        public void Print()
        {
            Console.WriteLine("ФИО = " + Fio + " Дата рождения = " + god + " Номер телефона = " + number + " Группа = " + group); ;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какое количество студентов вы хотите заполнить");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] stud = new Student[n];
            for (int i =0; i<n; i++)
            {
                Console.WriteLine("Ученик №"+(i+1));
                Console.WriteLine("Введите фамилию");
                stud[i].Fio = Console.ReadLine();
                Console.WriteLine("Введите год рождения");
                stud[i].god = Console.ReadLine();
                Console.WriteLine("Введите номер телефона");
                stud[i].number = Console.ReadLine();
                Console.WriteLine("Введите номер группы");
                stud[i].group = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите группу которую хотите найти");
            int gr = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (stud[i].group == gr)
                {
                    stud[i].Print();
                }
            }

            Console.ReadKey();
        }
    }
}
