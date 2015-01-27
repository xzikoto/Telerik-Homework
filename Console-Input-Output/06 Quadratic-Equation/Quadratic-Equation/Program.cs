using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Write b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Write c: ");
            double c = double.Parse(Console.ReadLine());

            double determinant = ((b*b) - ( 4 * a * c));
            if (determinant < 0) {
                Console.WriteLine("No solution");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("The first solution is {0}", ((-b - Math.Sqrt(determinant)) / (2 * a)));
                Console.WriteLine("The second solution is {0}", ((-b + Math.Sqrt(determinant)) / (2 * a)));

            }
            else {
                Console.WriteLine("Determinant = 0 --> {0}", (-b / (2 * a)));
            }

        }
    }
}
