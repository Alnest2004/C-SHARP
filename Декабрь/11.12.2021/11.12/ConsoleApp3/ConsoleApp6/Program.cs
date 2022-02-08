using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            string[] pupils = { "Петров А.А.","Пупкин В.О.", "Сидоров В.В.", "Петров С.А.", "Сидоров О.О.", "Иванов А.П.", "Иванов В.П.", "Сидоров А.Г." };
            foreach (var p in pupils)
                Console.WriteLine(p + ", однофамильцев: " + (pupils.Select(x => x.Split(' ')[0]).Count(x => x == p.Split(' ')[0]) - 1));
            Console.ReadKey();
        }
    }
}
