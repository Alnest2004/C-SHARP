using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Prim_ArraySort_my_Sort
{

    public class PERSON : IComparable, IComparer
    {
        private string fio;
        private int dataroz;
        public string mestoroz;


        public PERSON()
        {
            fio = "NoName";
            mestoroz = "";
            dataroz = 0;
        }
        public PERSON(string f, string o, int h)
        {
            fio = f;
            mestoroz = o;
            dataroz = h;
        }
        public void print()
        {
            Console.WriteLine("FIO = {0}   = {1} + {2}", fio, dataroz, mestoroz);
        }

        public int Compare(Object x0, Object y0)
        {
            PERSON x = (PERSON)x0;
            PERSON y = (PERSON)y0;
            if (Program.opr == 0)
            {
                if (String.Compare(x.mestoroz, y.mestoroz) < 0)
                    return -1;
                else if (x.mestoroz == y.mestoroz)
                    return 0;
                else
                    return 1;
            }
            else
            {
                if (x.dataroz < y.dataroz)
                    return -1;
                else if (x.dataroz == y.dataroz)
                    return 0;
                else
                    return 1;
            }

        }

        public int CompareTo(Object x)
        {
            return Compare(this, x);
        }
    }
    class Program
    {
        public static int opr = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование класса PERSON");
            Console.WriteLine("\nСписок до сортировки:");
            ArrayList x = new ArrayList();
            x.Add(new PERSON("Иванов", "Лида", 2003));
            x.Add(new PERSON("Петров", "Минс", 1977));
            x.Add(new PERSON("Борисов", "Барановии", 1966));
            x.Add(new PERSON("Сергеев", "Барановичи", 2001));
            x.Add(new PERSON("Ермалаев", "Минcк", 2003));
            PERSON st = new PERSON();
            for (int i = 0; i < x.Count; i++)
            {
                st = (PERSON)x[i];
                st.print();
            }

            PERSON stz = new PERSON();


            for (int i = 1; i < x.Count; i++)
            {
                st = (PERSON)x[i - 1];
                stz = (PERSON)x[i];
                if (st.mestoroz == stz.mestoroz)
                {
                    opr = 1;
                    break;
                }
            }

            IComparer Comp = new PERSON();


            x.Sort(Comp);
            Console.WriteLine("\nСписок после сортировки:");
            for (int i = 0; i < x.Count; i++)
            {
                st = (PERSON)x[i];
                st.print();
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
