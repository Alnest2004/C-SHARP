using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");

            Console.WriteLine("Введите четырехзначное число");
            int chi4 = Convert.ToInt32(Console.ReadLine());
            int chi = chi4 / 1000;
            int chi1= chi4 / 100 % 10;
            int chi2 = chi4 / 10 % 10;
            int chi3 = chi4 % 10;
            if  (chi+chi1 == chi2+chi3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите трехзначное число");
            int zad2 = Convert.ToInt32(Console.ReadLine());
            int summa = (zad2 % 10) + (zad2 / 10) % 10 + zad2 / 100;
            if (summa % 2 == 0)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите трехзначное число");
            int tri3 = Convert.ToInt32(Console.ReadLine());
            int tri313= tri3/100;
            int tri33 = tri3 / 10 % 10;
            int tri333 = tri3 % 10;
            if (tri3*tri3 == Math.Pow(tri313 + tri33 + tri333, 3))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите двухзначное число");
            int zad4 = Convert.ToInt32(Console.ReadLine());
            if ((zad4 % 2 == 0) && (zad4 > 9 && zad4 < 100))
            {
                Console.WriteLine(" true");
            }
            else Console.WriteLine("false");



            Console.WriteLine("Задание 5");

            Console.WriteLine("Введите стороны треугольника");
            int stor1 = Convert.ToInt32(Console.ReadLine());
            int stor2 = Convert.ToInt32(Console.ReadLine());
            int stor3 = Convert.ToInt32(Console.ReadLine());
            if (stor1==stor2 && stor2==stor3 && stor3==stor1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

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


            Console.WriteLine("Задание 7");

            Console.WriteLine("Введите три числа");
            int bnb1 = Convert.ToInt32(Console.ReadLine());
            int bnb2 = Convert.ToInt32(Console.ReadLine());
            int bnb3 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(bnb1)==Math.Abs(bnb2) | Math.Abs(bnb2) == Math.Abs(bnb3)| Math.Abs(bnb1) == Math.Abs(bnb3))
            {

                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите катеты первого треугольника");
            Console.WriteLine("Введите сторону a");
            int alk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int alk2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите катеты второго треугольника");
            Console.WriteLine("Введите сторону d");
            int blk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            int clk2 = Convert.ToInt32(Console.ReadLine());
            if (alk1/blk2 ==  alk2/clk2 | alk2/clk2 == alk1/blk2)
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");


            Console.WriteLine("Задание 9");

            Console.WriteLine("Введите стороны треугольника №1 ");
            int su1= Convert.ToInt32(Console.ReadLine());
            int su2= Convert.ToInt32(Console.ReadLine());
            int su3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны треугольника №2 ");
            int bb1 = Convert.ToInt32(Console.ReadLine());
            int bb2 = Convert.ToInt32(Console.ReadLine());
            int bb3 = Convert.ToInt32(Console.ReadLine());
            double per1 = (su1 + su2 + su3) * 0.5;
            double per2 = (bb1 + bb2 + bb3) * 0.5;
            double pl1 = Math.Sqrt(per1 * (per1 - su1) * (per1 - su2) * (per1 - su3));
            double pl2 = Math.Sqrt(per2 * (per2 - su1) * (per2 - su2) * (per2 - su3));
            if (pl1 == pl2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 10");
            Console.WriteLine("Введите сторону a");
            int apif = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int bpif = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c");
            int cpif = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(cpif, 2) == Math.Pow(bpif, 2) + Math.Pow(apif, 2))
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");

            Console.WriteLine("Задание 11");

            Console.WriteLine("Введите четырехзначное число");
            int chi44 = Convert.ToInt32(Console.ReadLine());
            int chi41 = chi44 / 1000;
            int chi14 = chi44 / 100 % 10;
            int chi24 = chi44 / 10 % 10;
            int chi34 = chi44 % 10;
            if (chi14 != chi24 && chi24!=chi34 && chi14!=chi34)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 12");
            Console.WriteLine("Введите x");
            int xcord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            int ycord = Convert.ToInt32(Console.ReadLine());
            if ((xcord >= 0) && (ycord >= 0)) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 13");

            Console.WriteLine("Введите верхнюю вершину  x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю вершину y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнюю вершину x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нижнюю вершину y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x точки, которую хотите проверить");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y точки, которую хотите проверить");
            int y3 = Convert.ToInt32(Console.ReadLine());
            if (x3>x1 && x3<x2 && y1>y3 && y3>y2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("Задание 14");
            Console.WriteLine("Введите a");
            int asr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int bsr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднее арифмитическое чисел " + asr + " и " + bsr);
            int csr = Convert.ToInt32(Console.ReadLine());
            if ((asr + bsr)* 0.5 == csr) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 15");

            Console.WriteLine("Введите четырехзначное число");
            int chis = Convert.ToInt32(Console.ReadLine());
            int chu = chis / 1000;
            int chu1 = chis / 100 % 10;
            int chu2 = chis / 10 % 10;
            int chu3 = chis % 10;
            if (chu < chu1 &&  chu1 < chu2 && chu2 < chu3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 16");
            Console.WriteLine("Введите трёхзначное число");
            int zad16 = Convert.ToInt32(Console.ReadLine());
            int zad16first = zad16 / 100;
            int zad16average = (zad16 / 10) % 10;
            int zad16last = zad16 % 10;
            if (zad16average - zad16first == zad16last - zad16average) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("Задание 17");

            Console.WriteLine("Введите трехзначное число");
            int fi = Convert.ToInt32(Console.ReadLine());
            int fi1 = fi / 100;
            int fi2 = fi / 10 % 10;
            int fi3 = fi % 10;
            if (fi2 / fi1 == fi3 / fi2 )
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 18");
            Console.WriteLine("Введите a");
            int zad18 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите d(куб)");
            int bkub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c(квадрат)");
            int ckvadr = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(a, 3) == bkub && Math.Pow(a, 2) == ckvadr) Console.WriteLine("true");
            else Console.WriteLine("false");


            Console.WriteLine("Задание 19");

            Console.WriteLine("Введите четырехзначное число");
            int ji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, которое хотите проверить в десятичной записи числа");
            int ji1 = Convert.ToInt32(Console.ReadLine());
            int ho = (ji / 1000) * 1000;
            int ho2 = (ji / 100 % 10)*100;
            int ho4 = (ji / 10 % 10) * 10;
            int ho3 = ji % 10  ;
            if(ho==ji1 | ho2==ji1 | ho3 == ji1 | ho4 == ji1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите четырёхзначное число");
            int zad20 = Convert.ToInt32(Console.ReadLine());
            if ((zad20 / 1000 == zad20 % 10) && ((zad20 / 100) % 10 == (zad20 % 100) / 10)) Console.WriteLine("true");
            else Console.WriteLine("false");
            Console.ReadKey();

        }










        }
}
