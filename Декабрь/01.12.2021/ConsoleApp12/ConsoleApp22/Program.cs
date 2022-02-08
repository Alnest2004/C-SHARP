
using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Marks mark = Marks.one;
            Console.WriteLine("Введите отметку");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                mark = Marks.one;
            }
            else if (x == 2)
            {
                mark = Marks.two;
            }
            else if (x == 3)
            {
                mark = Marks.three;
            }
            else if (x == 4)
            {
                mark = Marks.four;
            }
            else if (x == 5)
            {
                mark = Marks.five;
            }
            PrintMessage(mark);

            void PrintMessage(Marks marky)
            {
                switch (mark)
                {
                    case Marks.one:
                        Console.WriteLine("очень плохо");
                        break;
                    case Marks.two:
                        Console.WriteLine("плохо");
                        break;
                    case Marks.three:
                        Console.WriteLine("удовлетворительно");
                        break;
                    case Marks.four:
                        Console.WriteLine("хорошо");
                        break;
                    case Marks.five:
                        Console.WriteLine("отлично");
                        break;
                }
            }

            Console.ReadKey();
        }
        enum Marks
        {
            one = 1,
            two,
            three,
            four,
            five
        }
    }
}
