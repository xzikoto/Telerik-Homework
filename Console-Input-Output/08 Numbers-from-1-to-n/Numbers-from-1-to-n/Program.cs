using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_from_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the n number to print all the numbers in interval 1...n: \n");
            int nnumber = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < nnumber; i++)
            {
                Console.WriteLine("{0}", i);
                
            }
           
            }
        }
    }

