using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork[] works = new IWork[3] { new Student(), new Robot(), new Customer() };
            foreach (IWork item in works)
            {
                item.Work();
            }
            Console.ReadLine();
        }
    }

    class Student:IWork,IEat
    {
        public void Work()
        {
            Console.WriteLine("Student Work");
        }

        public void Eat()
        {
            Console.WriteLine("Student Eat");
        }
    }

    class Customer:IWork,IEat,IGetSalary
    {
        public void Work()
        {
            Console.WriteLine("Customer Work");
        }

        public void Eat()
        {
            Console.WriteLine("Customer Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Customer Get Salary");
        }
    }

    class Robot:IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }

    class Manager:Customer
    {

    }

    interface IWork
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }
}
