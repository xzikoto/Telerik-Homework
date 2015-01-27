using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "Todor";
            string middlename = " Slaveikov";
            string familyname = "Stankov";
            double balance = 1915271.49d;
            string nameofbank = "Dubaibank";
            string iban = "BG54YEBF023948574875";
            long firstcreditcard = 0012874721373212;
            long secondcreditcard = 23213192672388;
            long thirdcreditcard = 34798676576773;
            Console.WriteLine("Full name : {0} {1} {2}", firstname, middlename, familyname);
            Console.WriteLine("Holders ballence : {0} BGN", balance);
            Console.WriteLine("Bank name : {0}", nameofbank);
            Console.WriteLine("IBAN : {0}", iban);
            Console.WriteLine("Credit card numbers :\n 1. {0} \n 2. {1} \n 3. {2} ", firstcreditcard, secondcreditcard, thirdcreditcard);


        }
    }
}
