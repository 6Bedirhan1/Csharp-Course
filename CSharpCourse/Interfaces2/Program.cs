using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerDal());
            customerManager.Add(new OracleServerDal());

            ICustomerDal[] customerDal = new ICustomerDal[2] {new SqlServerDal(),new OracleServerDal() };
            foreach (ICustomerDal item in customerDal)
            {
                item.Add();
            }

            Console.ReadLine();

        }
    }
}
