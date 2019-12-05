using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_MVC_Identity.Models
{
    public class EmployeeView
    {

        public string Company { get; set; }

        public List<Employee> EmployeesIT { get; set; }

        public String EmployeesConsulting { get; set; }
    }
}
