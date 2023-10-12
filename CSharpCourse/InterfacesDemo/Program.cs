using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] { new Worker(), new Manager(), new Robot() };
            foreach (var worker in workers)
            {
                worker.Work();
            }
        }
    }

    interface IWorker
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

    class Worker:IWorker, IEat, IGetSalary
    {
        public void Work() 
        {

        }
        public void Eat()
        {

        }
        public void GetSalary()
        {

        }
    }

    class Manager:IWorker, IEat, IGetSalary
    {
        public void Work()
        {

        }
        public void Eat()
        {

        }
        public void GetSalary()
        {

        }
    }
    class Robot:IWorker
    {
        public void Work()
        {

        }
    }
}
