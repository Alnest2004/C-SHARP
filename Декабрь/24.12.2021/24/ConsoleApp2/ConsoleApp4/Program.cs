using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа а и b через пробел: ");
            int[] range = range = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            List<CDividers> _dividers = new List<CDividers>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                _dividers.Add(new CDividers(i));
            }
            Console.WriteLine("Для каждого целого числа на отрезке [a, b] вывести на экран количество делителей:");
            foreach (CDividers div in _dividers)
            {
                Console.WriteLine(div.ToString());
            }

            Console.WriteLine("Вывести на экран только те целые числа отрезка [a, b], у которых количество делителей равно заданному числу:");
            foreach (CDividers div in _dividers)
            {
                if (div.Dividers.Length == div.Num) Console.WriteLine(div.ToString());
            }

            Console.WriteLine("Вывести на экран только те целые числа отрезка [a, b], у которых количество делителей максимально:");
            CDividers _div = _dividers.OrderByDescending(d => d.Dividers.Length).First();
            Console.WriteLine(_div.ToString());

            Console.WriteLine("Для заданного числа А вывести на экран ближайшее следующее по отношению к нему число, имеющее столько же делителей, сколько и число А:");
            Console.Write("Введите число А: ");
            int A = int.Parse(Console.ReadLine());
            bool finded = false;
            foreach (CDividers div in _dividers)
            {
                if (div.Num >= A && div.Dividers.Length == A)
                {
                    Console.WriteLine(div.ToString());
                    finded = true;
                    break;
                }
            }
            if (!finded) Console.WriteLine("Подходящие числа отсутствуют.");

            Console.ReadKey();
        }


    }

    public class CDividers
    {
        public int Num { get; private set; }
        public int[] Dividers { get; private set; }
        public bool HaveDividers { get; private set; }

        public CDividers(int num)
        {
            Num = num;
            Dividers = GetDividers(num);
            if (Dividers.Length > 0) HaveDividers = true;
        }

        private int[] GetDividers(int num)
        {
            List<int> dividers = new List<int>();
            for (int i = 1; i <= (num / 2 > 2 ? num / 2 : 2); i++)
            {
                if (num % i == 0 && num != i) dividers.Add(i);
            }
            dividers.Add(num);
            return dividers.ToArray();
        }

        public override string ToString()
        {
            if (!HaveDividers) return String.Format("Число {0} не имеет делителей\r\n", Num);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Число: {0}", Num));
            sb.Append("Делители: ");
            foreach (int div in Dividers)
            {
                sb.Append(div + " ");
            }
            sb.AppendLine();
            return sb.ToString();
        }
    }
}