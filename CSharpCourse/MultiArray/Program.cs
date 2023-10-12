using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] city3 = new string[3] {"Trabzon","Ankara","İzmir"};


            int[,] numbers = new int[3, 2] 
            {
                {1,2},
                {4,5},
                {5,6}
            };

            
            string[,] cities = new string[5,3] 
            {
                {"Ankara","Bursa","Sivas"}, 
                {"İstanbul","Canakkale","Edirne"},
                {"İzmir","Antalya","Mugla"},
                {"Trabzon","Rize","Samsun"},
                {"Hatay","Maras","Adana" }
            };

            for (int i = 0; i <=4; i++)
            {
                for (int j = 0; j <=2; j++)
                {
                    Console.WriteLine(cities[i,j]);
                }
                Console.WriteLine("--------------------");
            }


            string[,] names = new string[4, 3] 
            {
                {"Ali","Ahmet","Arda"},
                {"Furkan","Bedirhan","Dodo"},
                {"Emre","Mehmet","Talha"},
                {"Sema","Nur","Rümeysa"}
            };

            for (int i = 0; i <= names.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= names.GetUpperBound(1); j++)
                {
                    Console.WriteLine(names[i,j]);
                }
                Console.WriteLine("********************");
            }
            Console.ReadLine();
        }
    }
}
