using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your number: ");
            int number = int.Parse(Console.ReadLine());
            int first = number % 10;
            int second = (number / 10) % 10;
            int third = (number / 100) % 10;
            int fourth = (number / 1000) % 10;
            
            Console.WriteLine("Your number is : {0}", number);

            Console.WriteLine("The sum of digits are : {0}" , (first + second + third + fourth));
            Console.WriteLine("Your number revert is : {0}{1}{2}{3}",first , second,  third , fourth);
            Console.WriteLine("The last digit in the first position look like {0}{1}{2}{3}", first, third, second, fourth);
            Console.WriteLine("Exchange the second and third digit {0}{1}{2}{3}", fourth, second, third, first);
        }
        }
}
