using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.OutputEncoding = Encoding.Unicode;
           char a = '\u0000';

           for (int i = 0; i < 256; i++)
           {
               Console.Write("{0} ", a);
               a++;

           }


            
            
















        }
    }
}
