using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите строку: ");
            char[] str = Console.ReadLine().ToCharArray();
            int sum = 0;
            string text = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ':')
                {
                    str[i] = char.Parse(" ");
                    sum++;
                }
                text += str[i];
            }
            Console.WriteLine("Кол-во удаленных символов " + sum);
            Console.WriteLine("Итоговая строка" + text);
        }
    }
}
