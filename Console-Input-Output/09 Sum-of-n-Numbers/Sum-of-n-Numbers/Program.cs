using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you want to calculate: ");
            double nnumbers = double.Parse(Console.ReadLine());
            double allsum = 0;
            for (double i = 1; i <= nnumbers; i++)
            {
                Console.WriteLine("Put the {0} number", i);
                double sum1 = double.Parse(Console.ReadLine());
                allsum += sum1;
                Console.WriteLine(allsum);

                // Every time you enter a number it will calculate what is the all sum for number you have reached .
                

            }   
            
        }
    }
}
