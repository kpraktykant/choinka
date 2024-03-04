using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj wysokosc choinki:");






            int n = int.Parse(Console.ReadLine());
            List<int> l = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 2!=0)
                {
                    l.Add(i);
                }
            }
            ///


            ///
            for (int i = 0; i < l.Count(); i++)
            {
                var g = new string('*', i);
                var s = new string(' ', n - i);
                Console.Write(s);
                Console.Write(g);
                Console.Write("*");
                Console.Write(g);
                Console.WriteLine(s);
            }
            Console.Write(new string(' ', n));
            Console.WriteLine("*");
            Console.ReadKey();
        }
    }
}
