using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingConnectionWithPostgre.Models
{
    public class Person
    {
        public int id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}
