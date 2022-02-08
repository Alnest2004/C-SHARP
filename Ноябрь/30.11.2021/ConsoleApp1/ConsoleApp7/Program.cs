using System;

namespace ConsoleApp3
{
    class Computer
    {
        string name, sphere, cntry, price, memry;
        int year;

        public Computer(string a, string b, string c, string d, string e, int f)
        {
            name = a;
            sphere = b;
            cntry = c;
            price = d;
            memry = e;
            year = f;
        }

        public void output(ref int ch)
        {

            if (ch >= year)
            {
                Console.WriteLine($"{name} {sphere} {cntry} {price} {memry} {year}");
                ch++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer[] computer = new Computer[3];

            computer[0] = new Computer("2015", "Комп1", "Игры", "Беларусь", "2гб", 10999);
            computer[1] = new Computer("2011", "Комп2", "Библиотека", "Австрия", "4гб", 12999);
            computer[2] = new Computer("2018", "Комп3", "Аптека", "Украина", "64гб", 14999);

            int ch = 0;
            ch = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < 3; i++)
            {
                computer[i].output(ref ch);
            }

            if (ch < 10999)
            {
                Console.WriteLine("Таких компьютеров нет");
            }
        }
    }
}