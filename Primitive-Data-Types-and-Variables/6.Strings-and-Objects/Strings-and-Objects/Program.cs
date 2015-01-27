using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            string first = "Hello";
            string second = "World";
            object concatenation = first + " " + second;
            string finalstring = (String)concatenation;
            Console.WriteLine (finalstring);


         }

    }
}


