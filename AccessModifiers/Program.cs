using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        public int Id;
        int Id2;                     //belirtilmediyse private alınır
        protected int Id3 { get; set; } //prop
    }

    class Student: Customer
    {

      public void Save()
        {
           
            Customer customer = new Customer();
            //customer.Id2=0;         //private olduğu için hata verir
            customer.Id=0;
            Id3 = 0; //inheritance olduğu için değişken direkt kullanılabildi

        }
    }

    internal class Course
    {
        public string Name { get; set; }
    }

    public class Instructor
    { 
        public void Delete()
        {
        }
    }
}
