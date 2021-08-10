using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListExamples();
            //ArrayListMatrix();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            /*Console.WriteLine(dictionary["table"]);*/ //çıktısı "tablo"

            foreach (var item in dictionary)
            {
                //Console.WriteLine(item);
                Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass")); //key tanımlanmadığı için false döndürür
            Console.WriteLine(dictionary.ContainsValue("tablo"));
            Console.ReadLine();
        }

        private static void List()
        {
            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            ////cities.Add(1); // yalnızca string veri kabul eder!!

            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities.Contains("Ankara")); //Ankara tanımlandığı için true döner

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer() { FirstName = "hasan", Id = 3 });
            //customers.Add(new Customer() { FirstName = "huseyin", Id = 4 });

            List<Customer> customers = new List<Customer>
            {
                new Customer {FirstName = "hasan", Id = 3}, //alternatif syntax
                new Customer {FirstName = "huseyin", Id = 4}
            };


            var customer1 = new Customer
            {
                FirstName = "erkan",
                Id = 5
            };
            customers.Add(customer1);

            /*   customers.Add(customer1);*/ //last index of'u test ettik

            customers.AddRange(new Customer[2] ///toplu ekleme
            {
                new Customer() {FirstName = "kaya", Id = 6},
                new Customer() {FirstName = "oya", Id = 7}
            });


            /*customers.Clear();*/ //tüm elemanları siler

            customers.Insert(0, customer1);

            //customers.Remove(customer1);
            //customers.Remove(customer1);
            customers.RemoveAll(c => c.FirstName == "erkan"); //belirtilmiş isime sahip tüm müşterileri sil


            var count = customers.Count();
            foreach (var customer in customers)
            {
                Console.WriteLine("name:" + customer.FirstName + " id: " + customer.Id);
            }

            Console.WriteLine(customers.Contains(customer1)); //metodun içine referansı yazdık
            Console.WriteLine(customers.IndexOf(customer1) + ". sırada");
            Console.WriteLine(customers.LastIndexOf(customer1) + ". sırada");
            Console.WriteLine(count + " customers added!");
        }

        //private static void ArrayListExamples()
        //{
        //    string[] Cities = new string[2] { "Ankara", "Adana" };
        //    Cities = new string[3]; //new'lendiği için eski veri değişkenden gider! çünkü yeni değer atanmadı
        //    //Cities[3] = "Adana";
        //    Console.WriteLine(Cities[0]); //çıktı boş olur

        //    ArrayList Cities = new ArrayList();
        //    Cities.Add("Ankara");
        //    Cities.Add("Adana");
        //    Cities.Add(1);
        //    Cities.Add('A');
        //    foreach (var city in Cities)
        //    {
        //        Console.WriteLine(city);
        //    }

        //    Cities.Add("İstanbul");
        //    Console.WriteLine(Cities[4]);
        //}

        //private static void ArrayListMatrix()
        //{
        //    ArrayList Matrix = new ArrayList();

        //    int k = 0;
        //    for (int i = 0; i <= 5; i++)
        //    {
        //        for (int j = 0; j <= 5; j++)
        //        {
        //            Matrix.Add(i);

        //            Console.Write("{0} : {1} = {2} \t", i, j, k);
        //            k += 1;
        //        }

        //        Console.WriteLine();
        //    }
        //}
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
