using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string countries = "united states";
            //Console.WriteLine(countries[0]);
            //foreach (var country in countries)
            //{
            //    Console.Write(country);
            //}
            //string countries2 = "united kingdom";

            //string total = countries + countries2;
            //foreach (var item in total)
            //{
            //    Console.Write(" {0}",item);
            //}

            //Console.WriteLine(" {0}  {1}", countries, countries2);

            string sentence = "Not All Those, Who Wander Are Lost!!!";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            //sentence = "xdxdbfdgdfg";
            
            Console.WriteLine(result);
            //Console.WriteLine(sentence);
           
            bool result3 = sentence.EndsWith("g");
            Console.WriteLine(result3);
            
            bool result4 = sentence.StartsWith("g");
            Console.WriteLine(result4);
            
            var result5 = sentence.IndexOf("Are");
            Console.WriteLine(result5);
            
            var result6 = sentence.IndexOf("are"); //büyük küçük harf duyarlılığı var!!! -1 döndürür
            Console.WriteLine(result6);
            
            var result7 = sentence.IndexOf(" ");
            Console.WriteLine(result7);
            
            var result8 = sentence.LastIndexOf(" ");
            Console.WriteLine(result8);

            var result9 = sentence.Insert(37,"*****");
            Console.WriteLine(result9);

            var result10 = sentence.Substring(22,3);
            Console.WriteLine(result10);

            var result11 = sentence.ToLower(); //ToUpper
            Console.WriteLine(result11);

            var result12 = sentence.Replace(" ","*"); 
            Console.WriteLine(result12);

            var result13 = sentence.Remove(4);
            Console.WriteLine(result13);



            Console.ReadLine();
        }
    }
}
