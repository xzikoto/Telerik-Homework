using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write  a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Write  b:");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (a - b > eps)
            {
                Console.WriteLine("The two numbers are not equal with precision eps");
            }
            else if(a == b) {
                Console.WriteLine("The two number are equal");
            
            }
            else if (b - a > eps) {
                Console.WriteLine("The two numbers are not equal with precison eps");
            }

            else
            {
                Console.WriteLine("The two numbers are equal with precision  0.000001");
            }
            
          }
    }
}
