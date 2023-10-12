using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] {1,3,5,7};
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            string name = "Bedirhan";
            int sayi = 61;
            sayi = sayi + 30;
            Console.WriteLine(sayi);

            string[,] names = new string[3, 2] 
            {
                {"Trabzon","Rize"},
                {"İstanbul","Edirne"},
                {"Antalya","Muğla"}
            };

            for(int i=0; i<=names.GetUpperBound(0); i++)
            {
                for(int j=0; j<=names.GetUpperBound(1); j++)
                {
                    Console.WriteLine(names[i, j]);
                }
            }
            Console.ReadLine();

        }
    }
}
