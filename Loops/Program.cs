using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //int a,b=0;
            //Console.WriteLine("bir sayı gir:");
            //a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <a ; i++)
            //{
            //    if (a % i == 0) { b =b+1; }

            //}
            //if (b<=2 && a>1) { Console.WriteLine("sayı asaldır!"); }
            //else Console.WriteLine("sayı asal değildir!");
            //int a=10;
            //while (a >= 0)
            //{
            //    Console.WriteLine(a);
            //    a--;

            //}
            //Console.WriteLine("son: {0}",a);

            //string[] a = new string[3]{"abc","bca","dbc"};
            //foreach (var letters in a)
            //{
            //    Console.WriteLine(letters);
            //}
            //i = Int16.Parse();
            int a = 0;
            string[,] nums = new string[11, 11];
            for (int i = 0; i<10; i++) {
                for (int j = 0; j<10; j++)
                {
                   

                    nums[i, j] =Convert.ToString(a);
                    a =a+1;
                    Console.WriteLine("[{0},{1}] :{2}",i,j, a);


                }
                
            }

            Console.ReadLine();
        }
    }
}
