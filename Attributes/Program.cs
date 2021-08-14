using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer{Id = 1,LastName = "göztok",Age = 26};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();

        }
    }
  
    class Customer
    {
     
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        [RequiredProperty]
        public int Age { get; set; }
    }
   
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew")]
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id +",  "+ customer.FirstName + ",  " + customer.LastName + ",  " + customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine(customer.Id + ",  " + customer.FirstName + ",  " + customer.LastName + ",  " + customer.Age);
        }
    }
    
    [AttributeUsage(AttributeTargets.All | AttributeTargets.Field,AllowMultiple = true)] //birden fazla  //allow multiple alt alta 1den fazla sayıda kullanılabilir
    [ToTable("Customers")]
    [ToTable("TblCustomers")]      
    class ToTableAttribute : Attribute
     {
         private string _tableName;

         public ToTableAttribute(string tableName)
         {
             _tableName = tableName;
         }

     }

   /* [AttributeUsage(AttributeTargets.All)] */               //attribute'u her yerde kullanılabilir hale getirir
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]         //yalnızca nesneler için kullanılabilir 
    /* [AttributeUsage(AttributeTargets.Class)] */              //yalnızca class'ları nitelerken kullanılabilir hale getirir
    class RequiredPropertyAttribute:Attribute
    {
        
    }

}
