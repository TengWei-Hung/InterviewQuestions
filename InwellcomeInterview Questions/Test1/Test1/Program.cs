using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (5 << 4) >> 2;
            Console.WriteLine("(5 << 4) >> 2 = " + a);

            int b = 5 << 4;
            Console.WriteLine("5 << 4 = " + b);

            int c = 80 >> 2;
            Console.WriteLine("80 >> 2 = " + c);

            int d = 5 << (4 >> 2);
            Console.WriteLine("(5 << (4 >> 2) = " + d);

            int e = 4 >> 2;
            Console.WriteLine("4 >> 2 = " + e);

            int f = 5 << 1;
            Console.WriteLine("5 << 1 = " + f);

            Console.ReadKey();
        }
    }
}
