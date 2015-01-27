using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Values_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? firstnullable = null;
            double? secondnullable = null;

            Console.WriteLine("The first nullable variable : {0} \nThe second nullable variable : {1}", firstnullable, secondnullable);

            firstnullable += 5;
            secondnullable += 6.6D;
            Console.WriteLine("The first nullable variable after adding a value: {0}" , firstnullable);
            Console.WriteLine("The second nullable variable after adding a value: {0}", secondnullable);

            firstnullable = 5;
            secondnullable = 6.6D;
            Console.WriteLine("The first nullable variable after changing the value : {0}", firstnullable);
            Console.WriteLine("The second nullable variable after changing the value: {0}", secondnullable);

        }
    }
}
