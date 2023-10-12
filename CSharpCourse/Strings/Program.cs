using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Bedirhan Ozcelik";

            int result = sentence.Length;
            Console.WriteLine(result);

            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("k");
            Console.WriteLine(result3);

            bool result4 = sentence.StartsWith("my name is");
            Console.WriteLine(result4);

            int result5 = sentence.IndexOf('a');
            Console.WriteLine(result5);

            int result6 = sentence.LastIndexOf('a');
            Console.WriteLine(result6);

            string result7 = sentence.ToUpper();
            Console.WriteLine(result7);

            Console.ReadLine();
        }
    }
}
