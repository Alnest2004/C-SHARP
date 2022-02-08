using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string stroka = "5*10-50-80/40=-2";
            var r = Regex.Matches(stroka, @"-?\d+").Cast<Match>().Select(x => int.Parse(x.ToString().ToArray()));
            int sum = 0;
            Console.WriteLine("Все целые числа: ");
            foreach (int x in r)
            {
                Console.Write(x);
                sum += x;
            }
            var r2 = Regex.Matches(stroka, @"-\d+").Cast<Match>().Select(x => int.Parse(x.ToString().ToArray()));
            var r3 = Regex.Matches(stroka, @"-?\d+").Cast<Match>().Select(x => x.Value).Distinct();


            Console.WriteLine($"\nСумма всех  чисел: {sum}");
            Console.WriteLine($"Кол-во чисел: {r.Count()}");
            Console.WriteLine($"Кол-во отрицательных чисел: {r2.Count()}");
            Console.WriteLine($"Кол-во неповторяющихся чисел: {r3.Count()}");
        }
    }
}
