﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Bit_from_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number");
            Console.Write("num: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("pos: ");
            int pos = int.Parse(Console.ReadLine());

            int check = 1 << pos;
            int checktwo = num & check;

            if (checktwo == 0)
            {
                Console.WriteLine("The bit in position {0} is '0' ", pos);
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            }
            else
            {
                Console.WriteLine("The bit in position {0} is '1' ", pos);
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
            }
        }
    }
}
