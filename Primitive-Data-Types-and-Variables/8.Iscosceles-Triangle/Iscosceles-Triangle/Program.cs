using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iscosceles_Triangle
{
class Program
{
    static void Main(string[] args)
    {

        char copyrightsymbol = '\u00A9';

        for (int i = 1; i <= 4; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("\n   {0}  ", copyrightsymbol);
            }

            else if (i == 2)
            {
                Console.WriteLine("\n  {0} {0}  ", copyrightsymbol);
            }

            else if (i == 3)
            {
                Console.WriteLine("\n {0}   {0}  ", copyrightsymbol);
            }

            else if (i == 4)
            {
                Console.WriteLine("\n{0} {0} {0} {0}", copyrightsymbol);
            }


            }
        }
    }
}

