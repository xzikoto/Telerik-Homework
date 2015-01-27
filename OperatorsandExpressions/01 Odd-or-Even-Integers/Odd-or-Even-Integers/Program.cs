using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number you want to know is it odd or even");
            int num = int.Parse(Console.ReadLine());
            
            
            
            if ((num % 2) == 0)
            {
                Console.WriteLine("The number is odd");
            }
            else {
                Console.WriteLine("The number is even");
            }
        }
    }
}
