using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class PERSON
    {
        string Fam, Name, Otch, Data, Adres, Number;

        public PERSON(string FAM, string NAME, string OTCH, string DATA, string ADRES, string NUMBER)
        {
            Fam = FAM;
            Name = NAME;
            Otch = OTCH;
            Data = DATA;
            Adres = ADRES;
            Number = NUMBER;
        }

        public void Vivod()
        {
            Console.WriteLine("ПЁРСОН. Фамилия = " + Fam + " Имя = " + Name + " Отчество = " + Otch + " Дата рождения = " + Data + " Адрес = " + Adres + " Номер телефона = " + Number);
        }


    }

    class Student : PERSON
    {
        int Fak, Kurs;

        public Student(int FAK, int KURS, string FAM, string NAME, string OTCH, string DATA, string ADRES, string NUMBER) : base(FAM, NAME, OTCH, DATA, ADRES, NUMBER)
        {
            Fak = FAK;
            Kurs = KURS;
        }

        public void Vivod()
        {
            base.Vivod();
            Console.WriteLine("Студент. Факультет = "+Fak+" Курс = "+Kurs);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] pirs = new Student[3];
            pirs[0] = new Student(3,4,"Никитыч","Никита", "Никитович","23.09.1998","Ул.Ленина","+375298102210");
            pirs[1] = new Student(9, 2, "Ордон", "Максим", "Викторович", "29.12.2003", "Ул.Комсомольская", "+375298438142");
            pirs[2] = new Student(5, 1, "Герый", "Виталий", "Иванович", "17.05.1982", "Ул.Коммунистическая", "+375294289429");
            for (int i=0; i<3; i++)
            {
                pirs[i].Vivod();
            }

            Console.ReadKey();

        }
    }
}
