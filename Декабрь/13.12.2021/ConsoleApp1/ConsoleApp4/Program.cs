using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string stroka = "Язык описания регулярных выражений состоит из символов двух видов: обычных символов и метасимволов.";
            string wordPattern = @"([[^\wА-Яа-я]+)";
            var matches = Regex.Matches(stroka, wordPattern);
            var words = matches.Cast<Match>().Select((word, index) => new { word, index }).ToArray();
            var indexes = words.GroupBy(n => n.word.Value.ToLower())
                .Where(g => g.Count() > 1)
                .SelectMany(n => n.Select(a => a.index));
            Console.Write("Позиции : ");
            foreach (var index in indexes)
            {
                Console.Write(index + " ");
            }

            var four = Regex.Matches(stroka, @"^?\b(\w){4}\b")
             .Cast<Match>().Select(word => word.Value);
            Console.WriteLine("\nСлова в 4 символа: ");
            foreach (var index in four)
            {
                Console.Write(index + " ");
            }
        }
    }
}
