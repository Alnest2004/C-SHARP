using System;

namespace ConsoleApp4
{

    public struct Aviareici
    {
        public string naznach;
        public int time;
        public string date;
        public int nomer;
        public int stoim;


        public void show()
        {
            Console.WriteLine("Номер рейса: {0}; Пункт назначения : {1}; Время вылета: {2}; Дата вылета {3}; Стоимость билета {4}", nomer, naznach, time, date, stoim);

        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Aviareici s;
            Console.WriteLine("Введите номер рейса: ");
            s.nomer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пункт назначения :");
            s.naznach = Console.ReadLine();
            Console.WriteLine("Время вылета :");
            s.time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дата вылета :");
            s.date = Console.ReadLine();
            Console.WriteLine("Стоимость билета :");
            s.stoim = Convert.ToInt32(Console.ReadLine());
            s.show();

            Aviareici[] mas = new Aviareici[3];

            for (int i = 0; i <3; ++i)
            {
                Console.WriteLine("Введите номер рейса: ");
                mas[i].nomer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите пункт назначения :");
                mas[i].naznach = Console.ReadLine();
                Console.WriteLine("Время вылета :");
                mas[i].time = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Дата вылета :");
                mas[i].date = Console.ReadLine();
                Console.WriteLine("Стоимость билета :");
                mas[i].stoim = Convert.ToInt32(Console.ReadLine());
                mas[i].show();
            }
            Console.WriteLine("Введите время для поиска");
            int s1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; ++i)
            {
                if (mas[i].time > s1)
                {
                    Console.WriteLine("Рейс под номером "+ mas[i].nomer+ "не вылетел");
                }
                else Console.WriteLine("Рейс под номером " + mas[i].nomer + "  вылетел");
            }
            Console.WriteLine("Введите сколько у вас денег");
            int s2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <3; ++i)
            {
                int kol = s2 / mas[i].stoim;
                Console.WriteLine("На рейс под номером " + mas[i].nomer + " вы можете купить "+ kol + " билетов" );
            }
        }
    }
}