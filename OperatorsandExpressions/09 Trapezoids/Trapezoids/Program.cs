using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Write b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Write h : ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of your Trapezoid is: {0}", (((a + b) / 2) * h));
            
            
        }
    }
}
