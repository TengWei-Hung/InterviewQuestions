using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string strNum = string.Empty;
                int Num = 0;

                do
                {
                    Console.WriteLine("Please enter the number : ");
                    strNum = Console.ReadLine();
                } while (!Int32.TryParse(strNum, out Num));

                int loop = 1;
                for (int i = 1; i < Num + 1; i++)
                    loop *= i;

                Console.WriteLine(string.Format("For loop : {0}! = {1}", strNum, loop));

                Console.WriteLine(string.Format("Factorial : {0}! = {1}", strNum, factorial(Num)));
            }
        }

        private static int factorial(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * factorial(num - 1);
        }
    }
}
