using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Add2());
            //int a=0, b=32;
            //GetNum(ref  a,  ref b);
            //Console.WriteLine("1st num:");
            //Console.WriteLine(a);
            //Console.WriteLine("2nd num:");
            //Console.WriteLine(b);

            //var result = Add2(a, b);

            //int n1 = 20, n2 = 10;
            //Console.WriteLine(n1);

            //Console.WriteLine("a:{0}", a);
            //Console.WriteLine("b:{0}", b);

            //var result = Add3( a, b);
            //Console.WriteLine(result);
            //Console.WriteLine("a:{0}",a);
            //Console.WriteLine("b:{0}", b);

            //Console.WriteLine(n1);

            int a=1, b=2, c=3, d=4;
            Console.WriteLine(Add4(a,b,c,d));
            

            Console.ReadLine();
        }

        //static void Add() {
        //    Console.WriteLine("added!");
        //}
        static void GetNum(ref int n1, ref int n2)
        {
            Console.WriteLine("write the 1st num:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write the 2nd num:");
            n2 = Convert.ToInt32(Console.ReadLine());


        }
        //static int Add2(int n1=25, int n2=40)
        //{
        //    Console.WriteLine("added!");
        //    int result = n1 + n2;
        //    return result;

        //}
        static int Add3( int n1,  int n2) {
            n1 = 3;
            return n1 + n2;
         
            //n2 = 6;
          
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();

        }
    }
}
