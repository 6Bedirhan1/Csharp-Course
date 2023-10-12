using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.firstName = "Bedirhan";
            customer.lastName = "Özçelik";
            customer.Id = 1;
            customer.city = "Trabzon";

            Console.WriteLine(customer.firstName);

            Console.ReadLine();
        }
    }
}
