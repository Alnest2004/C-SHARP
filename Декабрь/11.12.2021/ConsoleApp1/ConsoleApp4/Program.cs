using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            string s = "acbfd mmmmmm abrtd yuit";
            string[] r = MaxDistanceWords(s, 5);
            foreach (string t in r)

                Console.WriteLine(t + " ");
            Console.ReadKey();

        }
        public static string[] MaxDistanceWords(string s, int l)
        {
            string[] ts = s.Split();
            int dmax = int.MinValue;
            int q = 0, g = 0;
            for (int i = 0; i < ts.Length - 1; ++i)
            {
                for (int j = i + 1; j < ts.Length; ++j)
                {
                    int td = Distance(ts[i], ts[j], l);
                    if (td > dmax)
                    {
                        dmax = td;
                        q = i;
                        g = j;
                    }
                }
            }
            return dmax > int.MinValue ? new[] { ts[q], ts[g] } : new string[0];
        }
        public static int Distance(string a, string b, int n)
        {
            if (a.Length != n || b.Length != n)
                return int.MinValue;
            int d = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != b[i]) ++d;
            }
            return d;
        }
    }
    
}
