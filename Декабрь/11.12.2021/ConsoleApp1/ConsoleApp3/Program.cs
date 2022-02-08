using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            char[] gl = { 'а', 'е', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', };
            char[] sg = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'р', 'п', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', };
            Console.WriteLine("Введите текс: ");
            string a = Console.ReadLine();

            char[] b = a.ToCharArray();
            int g = 0;
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < gl.Length; j++)
                {
                    if (b[i] == gl[j])
                    {
                        g++;
                    }
                }
                for (int j = 0; j < sg.Length; j++)
                {
                    if (b[i] == sg[j])
                    {
                        s++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Гласных: {g}\nСогласных: {s}");
            if (g > s)
            {
                Console.WriteLine("Гласных больше!");
            }
            else
            {
                Console.WriteLine("Согласных больше!");
            }
        }
    }
}
