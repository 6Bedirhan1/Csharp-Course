using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 13;
            if (IsPrimeNumber(number) == true)
            {
                Console.WriteLine("{0} sayısı asaldır",number);
            }
            else
            {
                Console.WriteLine("{0} sayısı asal değildir",number);
            }
            Console.ReadLine();
        }

        static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number ; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
