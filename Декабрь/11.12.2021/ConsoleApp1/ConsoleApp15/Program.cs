using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] test = {
            "dsfwkwd2322ksdl ", "good342dsk32d23", "jsdfekksdlf;w;"
            };

            int indexMax = 0;
            int MaxCh = 0;
            int i = 0;
            foreach (var item in test)
            {
                string newStr = Regex.Replace(item, "[a-z]", string.Empty);
                // Console.WriteLine(newStr + " число букв" + newStr.Count());
                if (MaxCh < newStr.Count())
                {
                    MaxCh = newStr.Count();
                    indexMax = i;
                }

                i++;
            }

            Console.WriteLine(test[indexMax]);
            Console.WriteLine("Максимальное количесвто = " + MaxCh);
            Console.ReadKey();
        }
    }
}
