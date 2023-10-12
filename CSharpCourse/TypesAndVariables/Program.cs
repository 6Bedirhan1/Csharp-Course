using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 2147483647;
            long number2 = 921232132132143561;
            short number3 = -23445;
            byte number4 = 0;

            char character = 'a';

            bool result = false; // true veya false tutar. Mantıksal operatördür.

            double number5 = 12.5;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}",number4);
            Console.WriteLine("Number1 is {0}, Number2 is {1}, Number3 is {2}, Number4 is {3}",number1, number2,number3,number4);
            Console.WriteLine(character);
            Console.WriteLine(result);
            Console.WriteLine(number5);
            Console.ReadLine();
        }
    }
}
