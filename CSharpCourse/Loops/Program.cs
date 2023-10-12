using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number <= 100)
            {
                Console.WriteLine(number);
                number++;
            }

            Console.WriteLine("************************\n************************");
            
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            
            switch (number)
            {
                case 101:
                    Console.WriteLine("Number is 101");
                    break;
            }
            Console.ReadLine();
        }
    }
}
