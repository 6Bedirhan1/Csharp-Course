using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();

            Oracle oracle = new Oracle();
            oracle.Add();
            oracle.Delete();
         Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }

    class SqlServer:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by Sql");
        }
    }
    class Oracle:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by Oracle");
        }
    }
}
