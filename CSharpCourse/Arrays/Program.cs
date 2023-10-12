using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Bedirhan";
            students[1] = "Furkan";
            students[2] = "Ahmet Emir";

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------");

            string[] students2 = { "Adem", "Celal", "Fatma" };
            foreach (string student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------------------");

            string[] students3 = new string[2] { "Emrecan","Dogukan" };

            string name; 
            for (int i = 0; i<=1; i++)
            {
                name = students3[i];
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

    }
}
