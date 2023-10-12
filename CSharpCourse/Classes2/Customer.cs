using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Customer
    {
        public int Id { get; set; }

        private string _firstname;
        public string firstName
        {
            get
            {
                return "Mr." +_firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string lastName { get; set; }
        public string city { get; set; }
    }
}
