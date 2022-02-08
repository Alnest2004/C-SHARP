using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Prim_ArraySort_my_Sort
{

    public class COMPANY : IComparable, IComparer
    {
        public string naim;
        public int god;
        public int chislo;

        public COMPANY()
        {
            naim = "NoName";
            god = 0;
            chislo = 0;
        }
        public COMPANY(string f, int o, int h)
        {
            naim = f;
            god = o;
            chislo = h;
        }
        public void print()
        {
            Console.WriteLine("FIO = {0}   = {1} + {2}", naim, god, chislo);
        }

        public int Compare(Object x0, Object y0)
        {
            COMPANY x = (COMPANY)x0;
            COMPANY y = (COMPANY)y0;
            if (Program.opr == 0)
            {
                if (x.god < y.god)
                    return -1;
                else if (x.god == y.god)
                    return 0;
                else
                    return 1;
            }
            else
            {
                if (x.chislo < y.chislo)
                    return 1;
                else if (x.chislo == y.chislo)
                    return 0;
                else
                    return -1;
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
            x.Add(new COMPANY("Иваново", 2001, 22));
            x.Add(new COMPANY("Петрово", 1977, 33));
            x.Add(new COMPANY("Борисово", 1966, 55));
            x.Add(new COMPANY("Сергеево", 2003, 66));
            x.Add(new COMPANY("Ермалаево", 2003, 66));
            COMPANY st = new COMPANY();
            for (int i = 0; i < x.Count; i++)
            {
                st = (COMPANY)x[i];
                st.print();
            }
            COMPANY stz = new COMPANY();


            for (int i = 1; i < x.Count; i++)
            {
                st = (COMPANY)x[i - 1];
                stz = (COMPANY)x[i];
                if (st.god == stz.god)
                {
                    opr = 1;
                    break;
                }
            }

            IComparer Comp = new COMPANY();

            x.Sort(Comp);
            Console.WriteLine("\nСписок после сортировки:");
            for (int i = 0; i < x.Count; i++)
            {
                st = (COMPANY)x[i];
                st.print();
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
