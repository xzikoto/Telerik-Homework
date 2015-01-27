using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string family = "Doe";
            byte age = 15;
            string gender = "male";
            long personalid = 6902205762;
            string eg = "e.g.";
            int uniquenumber = 27561111;
           Console.WriteLine("First name : {0}", name);
           Console.WriteLine("Family name : {0}", family);
           Console.WriteLine("Age : {0}",age);
           Console.WriteLine("Gender : {0}", gender);
           Console.WriteLine("Personal ID number : {0}{1}", eg , personalid);
           Console.WriteLine("Unique employee number : {0}", uniquenumber);

        }
    }
}
