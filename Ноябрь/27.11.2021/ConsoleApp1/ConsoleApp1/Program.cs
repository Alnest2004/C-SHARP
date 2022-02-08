using System;

namespace ConsoleApp4
{

    public struct Infornacia
    {
        public string fio;
        public string klass;
        public int nomer;
        public int matem;
        public int fizika;
        public int ryssk;
        public int litra;
        public int srball;

        public void show()
        {
            Console.WriteLine("ФИО {0}; Класс {1}; Номер{2}; Оценка по матем{3}; ОЦенка по физике {4}; ОЦенка по русскому{5}; Оценка по литре{6}; Средний балл{7};", fio, klass, nomer, matem, fizika,ryssk,litra,srball);

        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Infornacia s;
            Console.WriteLine("Введите фамилию");
            s.fio = Console.ReadLine();
            Console.WriteLine("Введите класс");
            s.klass = Console.ReadLine();
            Console.WriteLine("Введите номер");
            s.nomer = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите оценку по матем");
            s.matem = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите оценку по физике");
            s.fizika = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите оценку по русскому");
            s.ryssk = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите оценку по литре");
            s.litra = int.Parse(Console.ReadLine());

            Infornacia[] mas = new Infornacia[2];

            for (int i = 0; i < 2; ++i)
            {
                Console.WriteLine("Введите фамилию");
                mas[i].fio = Console.ReadLine();
                Console.WriteLine("Введите класс");
                mas[i].klass = Console.ReadLine();
                Console.WriteLine("Введите номер");
                mas[i].nomer = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по матем");
                mas[i].matem = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по физике");
                mas[i].fizika = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по русскому");
                mas[i].ryssk = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите оценку по литре");
                mas[i].litra = int.Parse(Console.ReadLine());
                mas[i].show(); 
            }
            for (int i = 0; i < 2; ++i)
            {
                mas[i].srball = (mas[i].matem + mas[i].fizika + mas[i].ryssk + mas[i].litra) / 4;
                Console.WriteLine(mas[i].srball);
            }

            Console.WriteLine("Сортировка по ср. баллу");
                if (mas[0].srball > mas[1].srball)
                {
                    Console.WriteLine("Фио " + mas[0].fio);
                }
                else
            {
                Console.WriteLine("Фио " + mas[1].fio);
            }
        }
    }
}