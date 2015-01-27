using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Write b: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Write c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of a, b and c is: {0}", (a + b + c));

        }
    }
}
