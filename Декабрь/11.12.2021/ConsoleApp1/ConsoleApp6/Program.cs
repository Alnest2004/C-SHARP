using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Dictionary<char, int> d = new Dictionary<char, int>()
            {
                {'I',1 },{'V',5 },
                {'X',10 },
                {'L',50 },{'C',100 },{'D',500 },{'M',1000 },
            };
            string s = Console.ReadLine().ToUpper();
            Console.WriteLine(s.Select((x, i) => d[x] * (i < s.LastIndexOfAny(s.Distinct().Where(y => d[x] < d[y]).ToArray()) ? -1 : 1)).Sum());
        }
    }
}