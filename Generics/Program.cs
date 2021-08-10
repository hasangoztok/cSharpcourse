using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
             Console.WriteLine(item);

           
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Hasan"}, new Customer{FirstName = "Hüseyin"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities               //generic method
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product
    {
        
    }
    interface IProductDal:IRepository<Product>
    {
  

    }
    class Customer
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal:IRepository<Customer>
    {
       

    }

    interface IStudentDal:IRepository<Student>   //<int yazılırsa hata verir(int -> value type)  
    {                                           // reposityory'e , new() yazıldıysa string de hata verir(constructor olmalı))

    }

    class Student:IEntity
    {
        
    }

    interface IEntity
    {
        
    }

    class CustomerDal:ICustomerDal
    {
        public List<Customer> getAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class ProductDal:IProductDal
    {
        public List<Product> getAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    interface IRepository<T> where T: struct /*,IEntity, new()*/       //T'yi class tipiyle sınırladık(constrain) class olmak zorunda değil ama ref tip olmak zorunda (strings, arrays, objects of classes)
    {                                                      // , new() -> new'lenebilir bir nesne olma zorunluluğu getiriyor
        List<T> getAll();                                  //IEntity'den kalıtımlı olma zorunluluğu getirildi(veri tabanı nesnesi olmalı)                     
        T Get(int id);                                     //new() en sona yazılır
        void Add(T entity);                               //T:struct olursa sadece value type kullanılabilir
        void Delete(T entity);
        void Update(T entity);
    }
}
