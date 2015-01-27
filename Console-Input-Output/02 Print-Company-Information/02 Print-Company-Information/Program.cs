using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Company name: ");
            string companyName = Console.ReadLine();
            
            Console.WriteLine("Company address: ");
            string companyAdress = Console.ReadLine();
            
            Console.WriteLine("Phone number : ");
            string phoneNumber = Console.ReadLine();
            
            Console.WriteLine("Fax number: ");
            string faxNumber = Console.ReadLine();
            
            Console.WriteLine("Web site: ");
            string webSite = Console.ReadLine();
            
            Console.WriteLine("Manager first name: ");
            string managerFirstname = Console.ReadLine();
            
            Console.WriteLine("Manager last name: ");
            string managerLastname = Console.ReadLine();
            
            Console.WriteLine("Manager age: ");
            string managerAge = Console.ReadLine();
            
            Console.WriteLine("Manager phone:");
            string managerPhone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Adress: {0}", companyAdress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: \"{0}\", " , webSite);
            Console.WriteLine("Mager: {0} (age: {1}, tel. {2})",managerFirstname, managerAge,managerPhone);
            
        }
    }
}
