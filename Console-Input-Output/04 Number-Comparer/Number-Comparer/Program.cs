using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write b: ");
            int b = int.Parse(Console.ReadLine());

            int c = Math.Max(a, b);
            Console.WriteLine(c);
        }
    }
}
