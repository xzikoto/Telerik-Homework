using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
	        int b = 1;
	    
	        for (int i = 0; i < n; i++)
	        {
	            int temp = a;
	            a = b;
	            b = temp + b;
                Console.WriteLine(temp);
            }
      
        }

    }

}
    

