using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {


        private string _firstName; //encapsulation
        public string FirstName {

            get { return "Mr. " + _firstName; }
            set { _firstName = value; }
        }



        public int Id { get; set; }
        //public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
