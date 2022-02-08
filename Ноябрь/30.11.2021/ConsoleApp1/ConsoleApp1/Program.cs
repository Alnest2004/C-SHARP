using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            int zad2 = 367;
            int summa = (zad2 % 10) + (zad2 / 10) % 10 + zad2 / 100;
            if (summa % 2 == 0)
            {
                Console.WriteLine(summa+" - true");
            }
            else Console.WriteLine(summa + " - false");

            Console.WriteLine("Задание 4");
            int zad4 = Convert.ToInt32(Console.ReadLine());
            if ((zad4%2==0) && (zad4>9&&zad4<100)){
                Console.WriteLine(zad4 + " - true");
            }
            else Console.WriteLine(zad4 + " - false");

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите сторону a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a == b) || (b == c) || (a == c))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите стороны первого треугольника");
            Console.WriteLine("Введите сторону a");
            int alk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int blk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            int clk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника");
            Console.WriteLine("Введите сторону a");
            int alk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int blk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            int clk2 = Convert.ToInt32(Console.ReadLine());

            if (alk2/alk1 == blk2/blk1 && blk2 / blk1 == clk2 / clk1)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите сторону a");
            int apif = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int bpif = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            int cpif = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(cpif,2) == Math.Pow(bpif, 2) + Math.Pow(apif, 2))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите x");
            int xcord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int ycord = Convert.ToInt32(Console.ReadLine());
            if ((xcord >=0) && (ycord >= 0)) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 14");
            Console.WriteLine("Введите a");
            int asr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int bsr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднее арифмитическое чисел "+ asr + " И "+ bsr);
            int csr = Convert.ToInt32(Console.ReadLine());
            if (asr + bsr / 2 == csr) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 16");
            Console.WriteLine("Введите трёхзначное число");
            int zad16 = Convert.ToInt32(Console.ReadLine());
            int zad16first = zad16 / 100;
            int zad16average = (zad16 / 10) % 10;
            int zad16last = zad16 % 10;
            if (zad16average - zad16first == zad16last - zad16average) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 18");
            Console.WriteLine("Введите a");
            int zad18 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d(куб)");
            int bkub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c(квадрат)");
            int ckvadr = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(a,3) == bkub && Math.Pow(a, 2) == ckvadr) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите четырёхзначное число");
            int zad20 = Convert.ToInt32(Console.ReadLine());
            if ((zad20 /1000 == zad20 % 10) && ((zad20/100)%10 == (zad20%100)/10)) Console.WriteLine("true");
            else Console.WriteLine("false");
            Console.ReadKey();
        }
    }
}
