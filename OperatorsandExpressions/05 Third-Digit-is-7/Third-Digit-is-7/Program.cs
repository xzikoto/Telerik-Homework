using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number: ");
            long number = long.Parse(Console.ReadLine());

            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("Your third number right to left is 7");
            }
            else {
                Console.WriteLine("Your third numbe is right to left is not 7");
                 }
        }
    }
}
