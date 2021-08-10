using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //add ikisi için de ortak ancak delete 2si için de ayrı implemente edildi!!!
            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }

        
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default!");  //tamamlanmış metod
        }

        public abstract void Delete();   //tamamlanmamış metod
    }

    class SqlServer:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql!");
        }
    }

    class Oracle:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle!");
        }
    }
}
