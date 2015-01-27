using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravitation_on_the_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write you weight on the Earth");
            double weightonearth = double.Parse(Console.ReadLine());
            double logic = ((17 * weightonearth) / 100);
            Console.WriteLine("Your weight on the moon will be : {0}", logic);

        }
    }
}
