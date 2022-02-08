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
            
            Console.WriteLine("Введите день недели = ");
            string den = Console.ReadLine().ToLower();
            switch (den)
            {
                case "понедельник": Console.WriteLine("Приёмнй часы = 9:00-11:00|13:10-16:00");
                    break;
                case "вторник":
                    Console.WriteLine("Приёмнй часы = 9:00-11:00|13:10-16:00");
                    break;
                case "среда":
                    Console.WriteLine("Приёмнй часы = 10:00-11:30|12:30-15:00");
                    break;
                case "четверг":
                    Console.WriteLine("Приёмнй часы = 8:00-12:20|19:10-20:00");
                    break;
                case "пятница":
                    Console.WriteLine("Приёмнй часы = 18:00-19:00|20:10-21:00");
                    break;
                case "суббота":
                    Console.WriteLine("Выходной");
                    break;
                case "воскресенье":
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Вы ввели не правильный день недели");
                    break;

            }
            Console.ReadKey();
        }
    }
}
