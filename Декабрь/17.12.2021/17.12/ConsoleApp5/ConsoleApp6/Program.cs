using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите количество баллов = ");
            int den = Convert.ToInt32(Console.ReadLine());
            if (den>=90 && den <= 100)
            {
                Console.WriteLine("Оценка = Отлично");
            }
            if (den >= 70 && den <= 89)
            {
                Console.WriteLine("Оценка = Хорошо");
            }
            if (den >= 50 && den <= 69)
            {
                Console.WriteLine("Оценка = Удовлетворительно");
            }
            if (den < 50)
            {
                Console.WriteLine("Оценка = Неудовлетворительно");
            }


            Console.ReadKey();
        }
    }
}
