using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6");
            string text = "Обычный текст (текст в скобках) (ещё такой)";
            char[] text_ar = text.ToCharArray();
            bool flag = true;
            string res = "";
            for (int i = 0; i < text_ar.Length; i++)
            {
                if (text_ar[i] == '(') flag = false;
                else if (text_ar[i] == ')') flag = true;
                else if (flag) res += text_ar[i];
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
