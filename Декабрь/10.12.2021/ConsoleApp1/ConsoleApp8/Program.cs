using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите строку");
            string dat = Console.ReadLine();
            char[] alfavit = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'Й', 'И', 'Ц', 'У', 'К', 'Н', 'Г', 'Ш', 'Щ', 'З', 'Х', 'Ъ', 'Ф', 'Ы', 'П', 'Р', 'О', 'Л', 'Д', 'Ж', 'Э', 'Я', 'Ч', 'С', 'М', 'Т', 'Ь', 'Ю', 'ё', 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю' };
            string rez = "";
            foreach (char q in alfavit)
            {
                int k = dat.Where(s => s == q).Count();
                if (k != 0) rez += q.ToString() + "-" + k.ToString() + "раз" + "\r\n";
            }
            Console.WriteLine(rez);

        }
    }
}
