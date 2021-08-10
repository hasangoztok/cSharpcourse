using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            //    if (n == 10)
            //    {
            //        Console.WriteLine(n == 10 ? "n is 10" : "n is not 10!!!"); //single line if
            //    }
            //    else
            //    {
            //        Console.WriteLine("n is not 10!!!");
            //    }

            //    Console.ReadLine();
            //switch (n)
            //{
            //    case 10:
            //        Console.WriteLine("n is 10");
            //        break;
            //    case 11:
            //        Console.WriteLine("n is 11");
            //        break;
            //    default:
            //        Console.WriteLine("n is not 10 or 11");
            //        break;
            //}

            if (n >= 0 && n <= 100) {
                Console.WriteLine("is in 0 & 100 range");
                if (n>=50 && n<=60)
                {
                    Console.WriteLine("is in 50 & 60 range");
                }
                else
                {
                    Console.WriteLine("is not in 50 & 60 range");
                }
            }
            else
            {
                Console.WriteLine("is not in 0 & 100 range");
            }
            
            Console.ReadLine();

        }
    }
}
