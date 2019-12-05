using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Example_MVC_Identity.Models;
using Newtonsoft.Json;

namespace Example_MVC_Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            EmployeeView model = new EmployeeView();
            List<Employee> employeeITList = new List<Employee>(){ 
                new Employee {Id=1, Name = "Abril", LastName = "Fernandez", Department="IT", Position="Software Developer"},
                new Employee {Id=2, Name = "Alvaro", LastName = "Gonzalez", Department="IT", Position="Software Developer"},
                new Employee {Id=3, Name = "Jorge", LastName = "Garrido", Department="IT", Position="Software Developer"}
            };
            List<Employee> employeeConsultingList = new List<Employee>(){
                new Employee {Id=4, Name = "Alejandro", LastName = "Sarabia", Department="Consulting", Position="Consulting"},
                new Employee {Id=5, Name = "Alvaro", LastName = "Gonzalez", Department="Consulting", Position="Consulting"},
                new Employee {Id=5, Name = "Khadin", LastName = "Magallon", Department="Consulting", Position="Consulting"}
            };

            model.Company = "ATAsoft";
            model.EmployeesIT = employeeITList;
            model.EmployeesConsulting = JsonConvert.SerializeObject(employeeConsultingList); 

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
