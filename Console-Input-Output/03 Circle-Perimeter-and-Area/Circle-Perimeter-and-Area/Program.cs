using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write r");
            float radious = float.Parse(Console.ReadLine());
            float pi = 3.14F;
            float two = 2F;

            if(radious > 0) {
            Console.WriteLine("The area is {0}", pi * (radious * radious));
            Console.WriteLine("The peremeter is {0}",  (two * pi) * radious);
            }
        }
    }
}
