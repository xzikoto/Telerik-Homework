using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] usernumbers = Console.ReadLine().Split();
            int a = Convert.ToInt32(usernumbers[0]);
            int b = Convert.ToInt32(usernumbers[1]);
            int c = Convert.ToInt32(usernumbers[2]);
            int d = Convert.ToInt32(usernumbers[3]);
            int e = Convert.ToInt32(usernumbers[4]);
            int sumof5numbers = a + b + c + d + e;
            Console.WriteLine("The sum of all 5 numbers is : {0}", sumof5numbers);

        }
    }
}
