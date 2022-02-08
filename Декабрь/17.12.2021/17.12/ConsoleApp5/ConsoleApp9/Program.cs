using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 9");
            Console.WriteLine("Введите 1-мужчина, 2-женщина");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Мужские имена: Максим, Александр, Иван, Святополк, Святослав");
                    break;
                case 2:
                    Console.WriteLine("Женские имена: Янина, Анна, Ангелина, Алина, Алёна");
                    break;
            }
            Console.ReadKey();
        }
    }
}
