using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a and b (width and height): ");
            Console.WriteLine("\na:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("\nb: ");
            int height = int.Parse(Console.ReadLine());
            int perimeter = (2 * width) + (2 * height);
            int area = (width * height);

            if (width == height)
            {
                Console.WriteLine("Why you want to calculat square area or peremeter");

            }
            else
            {
                Console.WriteLine("The peremeter is {0}", perimeter);
                Console.WriteLine("The area is {0}", area);
            }
            

        }
    }
}
