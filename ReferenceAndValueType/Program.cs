using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 20;
            //n2 = n1;
            //n1 = 30;
            //Console.WriteLine("n1:{0}  n2:{1}",n1,n2);

            //string[] cities1 = new string[] {"urfa", "canakkale", "manisa"};
            //string[] cities2 = new string[] { "adana", "ankara", "ardahan" };
            //cities2 = cities1;     //hafızada aynı alana denk gelirler
            //cities1[0] = "İstanbul"; //yapılan değişiklik 2 diziyi de etkiler
            //Console.WriteLine(cities2[0]);
            //Console.WriteLine(cities1[0]);
            //foreach (var city2 in cities2)
            //{
            //    Console.WriteLine(city2);
            //}
            //foreach (var city2 in cities1)
            //{
            //    Console.WriteLine(city2);
            //}

            DataTable dataTable; /*= new DataTable(); */  //performans problemi!!! aynı veri yazılacağı için new'lemek gereksiz
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2; /*dataTable2 = dataTable; önceden böyleydi, 2 newlendiği için düzenlendi*/



            Console.ReadLine();

        }
    }
}
