using System;

namespace ConsoleApp4
{



    class Program
    {
        enum dela
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void DelaOp(dela op)
        {
            string result = "";
            switch (op)
            {
                case dela.Monday:
                    result += "Помыть полы";
                    break;
                case dela.Tuesday:
                    result += "Покушать";
                    break;
                case dela.Wednesday:
                    result += "Помыться";
                    break;
                case dela.Thursday:
                    result += "Одеться";
                    break;
                case dela.Friday:
                    result += "Обуться";
                    break;
                case dela.Saturday:
                    result += "Нарядить ёлку";
                    break;
                case dela.Sunday:
                    result += "Погладить кота";
                    break;
            }

            Console.WriteLine("Сегодня нужнооо {0}", result);
        }

        static void Main(string[] args)
        {
            DelaOp(dela.Monday);
            DelaOp(dela.Thursday);
            DelaOp(dela.Saturday);
            DelaOp(dela.Wednesday);




        }
    }
}
