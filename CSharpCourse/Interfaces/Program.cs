﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { FirstName = "Bedirhan", LastName = "Ozcelik", Id = 1 };
            personManager.Add(customer);
            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        //interfaces
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //class property
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        //interfaces
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //class property
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
