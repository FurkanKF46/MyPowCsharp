using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPow(2.00000,10));
            Console.WriteLine(MyPow(2.10000,3));
            Console.WriteLine(MyPow(2.00000,0));
            Console.WriteLine(MyPow(2.00000,-2));
        }
        public static double MyPow(double x, int y) 
        {
            if (y > 0)
            {
                double result = 1;
                for (int i = 0; i < y ; i++)
                {
                    result = result * x;
                }
                return result;
            }
            else if (y == 0)
                return 1;
            else
            {
                double result = 1;
                for (int i = y; i < 0; i++)
                {
                    result= result * x;
                }
                return 1 / result;
            }
        }
    }
}
