using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Write your number: ");
            int number = int.Parse(Console.ReadLine());
            bool canbedivided = number % 7 == 0 && number % 5 == 0;


            if (canbedivided == true)
            {
                Console.WriteLine("Can it be devided : {0}", canbedivided);
            }
            else {
                Console.WriteLine("Can it be devided : {0}", canbedivided);
            }
        }
    }
}
