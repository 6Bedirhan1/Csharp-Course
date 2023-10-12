using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.firstName = "Bedirhan";
            customer.lastName = "Özçelik";
            customer.Id = 1;
            customer.city = "Trabzon";

            Customer customer2 = new Customer
            {
                Id = 2,
                firstName = "Furkan",
                lastName = "Özçelik",
                city = "Trabzon"
            };
            Console.WriteLine(customer2.firstName);



            Console.ReadLine();
        }
    }

    class ProductManager 
    {
        public void Add()
        {
            Console.WriteLine("Product added");
        }

        public void Update()
        {
            Console.WriteLine("Product updated");
        }
    }
}
