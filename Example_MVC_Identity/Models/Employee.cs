using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_MVC_Identity.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }
    }
}
