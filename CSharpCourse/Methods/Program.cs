using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            string result = City();
            Console.WriteLine(result);
            Console.WriteLine(Add2(20,40));
            var result2 = Add4(1,2,3,4,5);
            Console.WriteLine(result2);

            Console.WriteLine(Add5(1,2,3,4));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Ürün eklendi");
        }

        static int Add2(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static string City()
        {
            return "Trabzon";
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Length;
        }

        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
       
    }
}
