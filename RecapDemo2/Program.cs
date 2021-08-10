using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            CustomerManager customerManager2= new CustomerManager();
            //customerManager.Logger=new DatabaseLogger();
            //customerManager.Logger = new FileLogger();
            customerManager.Logger = new SmsLogger();
            customerManager2.Logger = new DatabaseLogger();
            customerManager.Add();
            customerManager2.Add();
            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
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
            Console.WriteLine("Logged to file!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }

  
}
