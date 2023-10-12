using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] { new Customer { FirstName="Bedirhan"}, new Student { FirstName="Furkan"}, new Person {FirstName="Ahmet Emir"} };
            foreach (var person in persons) 
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {

    }
    class Student:Person
    {

    }
}
