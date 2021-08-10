using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor = new Instructor(); //public olarak tanımlandığı için erişime izin verdi
            instructor.Delete();
            Course course = new Course(); //internal olduğu için hata verdi
            Customer customer = new Customer();  //internal olduğu için hata verdi
        }
    }
}
