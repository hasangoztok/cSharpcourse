using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesANDvariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world!");
            //
            int n1 = 1000000000;
            short n2=32767;
            long n3 = 1111111111111111111;
            byte n4 = 254;
            bool condition = false;
            char c = 'x';
            double n6 = 10.4;
            decimal n7= 10.5m;
            int n8;
            var a = 12;
            // a = 'v';  //başta atanan değişken ne ise ona göre devam eder. çıktı ascII değeri olur.
            Console.WriteLine(a);


            n8=Convert.ToInt32(Console.ReadLine());
            if (n8 == 0)
            {
                Console.WriteLine(Days.Monday);
            }
            else Console.WriteLine(Days.Tuesday);
            //Console.WriteLine("n1: {0} \n n2: {1} \n n3: {2} \n n4:{3} \n {4}",n1,n2,n3, condition,(int)c);
            Console.ReadLine();
        
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday
    }
}
