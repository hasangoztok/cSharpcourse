using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //demo2();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
              new  SqlServerCustomerDal(),
               new OracleCustomerDal(),
               new MySqlCustomerDal()
            };

            foreach (var CustomerDal in customerDals)
            {
                CustomerDal.Add();
            }


            Console.ReadLine();
        }

        private static void demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        //    private static void InterfacesIntro()
        //    {
        //        PersonManager manager = new PersonManager();
        //        //Customer customer = new Customer{
        //        //Id = 1,
        //        //FirstName = "hasan",
        //        //LastName = "goztok",
        //        //Adress = "urfa"
        //        //};
        //        manager.Add(new Customer {Id = 1, FirstName = "hasan", LastName = "goztok", Adress = "urfa"});

        //        Product product = new Product
        //        {
        //            Id = 2,
        //            FirstName = "whooper",
        //            LastName = "junior",
        //            Type = "food"
        //        };
        //        manager.Add(product);


        //        Student student = new Student {Id = 1, FirstName = "asdasd", LastName = "ejkrlert"};
        //        manager.Add(student);
        //    }
        //}
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Product : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Type { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Type { get; set; }
        }
        //class Customer : IPerson
        //{
        //    public int Id { get; set; }
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //    public string Adress { get; set; }
        //}

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Id);


            }

        }
    }
}