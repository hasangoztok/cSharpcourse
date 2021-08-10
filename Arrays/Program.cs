using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] products = new String[3]; /*{ "abc","bac","cde"};*/
            //products[0]= "whooper";
            //products[1] = "big king";
            //products[2] = "steakhouse";
            //for (int i = 0; i < 3; i++) {
            //    Console.WriteLine(products[i]);
            //}

            string[,] regions = new string[3, 3] {
             {"a","b","c" },
             {"d","e","f" },
             {"g","h","i" },

                };
            for (int i = 0; i <= regions.GetUpperBound(0); i++) {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.Write("{0} {1} = {2} \t",i,j, regions[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    
        }
}

