using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer{City = "urfa", FirstName = "hasan",LastName = "goztok",Id = 12};
            //customer.Id = 13;
            //customer.City = "urfa";

            Person[] person = new Person[3]
            {
                new Person{FirstName = "hasan"}, new Student{FirstName = "huseyin"},new Customer{FirstName = "sevim"}

            };

            foreach (var VARIABLE in person)
            {
             Console.WriteLine(VARIABLE.FirstName);   
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id{get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Department { get; set; }
    }
}
