using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
       
            
            static void Main(string[] args)
            {
            Console.WriteLine("Задание 1");
            Console.Write("Введите строку  ");
                string stroka = Console.ReadLine();

                Console.Write("Введите корень ");
                string poisk = Console.ReadLine();

                MatchCollection match = Regex.Matches(stroka, poisk, RegexOptions.IgnoreCase);
                findMyText(stroka, match);
            }

            static void findMyText(string text, MatchCollection myMatch)
            {
                Console.WriteLine(" ", text);

                for (int i = 0; i < text.Length; i++)
                {
                    foreach (Match m in myMatch)
                    {
                        if ((i >= m.Index) && (i < m.Index + m.Length))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = default;
                        }
                    }
                    Console.Write(text[i]);
                }
                Console.BackgroundColor = default;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
    }

