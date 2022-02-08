using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            string ch = "ма";
            string ch1 = "к";
            int k=0;
            
            string text5 = Console.ReadLine();
            string[] words = text5.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                int indexOfChar = s.IndexOf(ch);
                if (indexOfChar == 0){
                    Console.WriteLine(s);
                    k++;
                }

            }

            Console.WriteLine("Количество слов="+k);

            Console.WriteLine("Второе задание");
            string text2 = Console.ReadLine();
            string[] words2 = text2.Split(new char[] { ' ' });
            int all=0;
            int kall = 0;

            foreach (string s1 in words2)
            {
                all++;
                int indexOfChar = s1.IndexOf(ch1);
                if (indexOfChar == 0)
                {
                    Console.WriteLine(s1);
                    kall++;
                }


            }
            int procent = (kall * 100) / all;
            Console.WriteLine("Процентное соотношение:="+procent+"%");

            Console.WriteLine("Третье задание");

            string VOWELS = "ауеёиоыэюяАУЕЁИОЫЭЮЯ";
            string PUNCTUATION = " ,.!?-";
            var text = Console.ReadLine();
            var counter = new List<int> { 0 };
            var index = 0;
            foreach (var symbol in text)
            {
                if (VOWELS.IndexOf(symbol) != -1)
                    counter[index]++;
                else if 
                    (PUNCTUATION.IndexOf(symbol) != -1 && counter[index] != 0)
                {
                    index++;
                    counter.Add(0);
                }
            }
            counter.Where(count => count > 0).GroupBy(count => count).OrderBy(group => group.Key).ToList().ForEach(result => Console.WriteLine("Слогов: {0}, слов: {1}", result.Key, result.Count()));
        }
    }
}
