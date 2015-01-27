using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Interval_Dividable_by_Given_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The number from where you want to check: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("The number where ends: ");
            int b = int.Parse(Console.ReadLine());
            
            int counter = 0;
            
            for (int i = a; i <= b; i++) 
            {
                if ((i % 5) == 0)
                {
                    Console.WriteLine("{0}",i++);
                    counter++;
                }    
            }
            Console.WriteLine("The p is: {0}" , counter);

        
            }
        }
    }

