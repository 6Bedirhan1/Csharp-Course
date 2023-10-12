using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class MySqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by MySql code");
            //base.Add();
        }
    }
    class SqlServer:Database
    {

    }
}
