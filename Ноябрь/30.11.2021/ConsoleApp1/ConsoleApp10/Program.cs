using System;

namespace ConsoleApp3
{
    class Znak
    {
        string fam, name, znak, dataroz;
        string y;

        public Znak(string a, string b, string c, string d)
        {
            fam = a;
            name = b;
            znak = c;
            dataroz = d;
        }

        public void output(ref int ch)
        {

            if (name == y)
            {
                Console.WriteLine($"{name} {fam} {znak} {dataroz} ");
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Znak[] computer = new Znak[3];

            computer[0] = new Znak ("Марина", "Иванова", "Телец", "21.04.2012");
            computer[1] = new Znak ("Катя", "Петрова", "Рак", "31.05.2015");
            computer[2] = new Znak ("Света", "Синицина", "Лев", "17.07.2013");

            Console.WriteLine("Введите фамилию");
         string y = Console.ReadLine();

        }
    }
}