using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущую отметку");
            int bal = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine((Marks)bal);
            Console.WriteLine((Marks)3);
            Console.ReadKey();
        }

        enum Marks
        {
            очень_плохо =1,
            плохо,
            удовлетворительно,
            хорошо,
            отлично
        }
    }
}
