using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(); //parantez içinde değer verilmezse 15'i alır
            //customerManager.Add();
            //customerManager.List();

            ////Product product = new Product{Id = 1, Name = "Laptop"};
            //Product product2 = new Product(2,"Computer");
            //product2.List();

            //EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
           
            //employeeManager.Add();

            //PersonManager personManager = new PersonManager("hos geldiniz!");
            //personManager.Add();

            Teacher.Number = 12;

            Utilities.Validate();

            //Manager.DoSomething();     //static olduğu için instance üretmedik
            //Manager manager = new Manager();  //instance
            //manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()      //construction overload
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items!", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added {0} items!", _count);
        }
    }

    class Product
    {
        public Product()
        {
            
        }

        private int _id;
        private string _name;
        public Product(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }
        //public int Id { get; set; }
        //public string Name { get; set; }

        public void List()
        {
            Console.WriteLine("id of product is "+_id);
            Console.WriteLine("name of product is "+_name);
           
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to DB!");

        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");

        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _message;

        public BaseClass(string message)
        {
            _message = message;

        }
        public void Message()
        {
            Console.WriteLine("{0}",_message);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string message):base(message)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Addded!");
            Message();
        }
    }

    static class Teacher
    {
        public static  int Number { get; set; }
    }

    static class Utilities           
    {
        static Utilities()          //static constructor örneği
        {
            Console.WriteLine("Hi!!!");
        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
