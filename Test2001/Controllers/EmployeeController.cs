using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2001.Models;

namespace Test2001.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeCharity101()
        {
            IList<Employee101> listEmployees = new List<Employee101>()
            {
                new Employee101() { EmpId = "001", Name = "Jamal Nasir",Position = "Defender", 
                    Campus = "MIIT", Salary = 4631},
                new Employee101() { EmpId = "002", Name = "Mohkhtar Dahari",Position = "Striker",
                    Campus = "BMI", Salary = 3850},
                new Employee101() { EmpId = "003", Name = "Soh Chin Aun",Position = "Defender",
                    Campus = "MFI", Salary = 10020},
                new Employee101() { EmpId = "004", Name = "Santokh Singh",Position = "Defender",
                    Campus = "BMI", Salary = 2050},
                new Employee101() { EmpId = "005", Name = "R.Arumugam",Position = "Goalkeeper",
                    Campus = "MIIT", Salary = 16205},
                new Employee101() { EmpId = "006", Name = "Shukor Salleh",Position = "Midfielder",
                    Campus = "MIIT", Salary = 6631},
                new Employee101() { EmpId = "007", Name = "Hassani Sani",Position = "Striker",
                    Campus = "MIIT", Salary = 5300}
            };
            ViewBag.OrderName = listEmployees.OrderBy(x => x.Name);

            ViewBag.CountAll = listEmployees.Count();
            ViewBag.HighSalary = listEmployees.Max(x => x.Salary);
            ViewBag.LowSalary = listEmployees.Min(x => x.Salary);
            ViewBag.AverageSalary = listEmployees.Average(x => x.Salary);
            ViewBag.AverageSalaryMIIT = listEmployees.Where(x => x.Campus == "MIIT")
               .Average(x => x.Salary);
            return View(listEmployees);
        }
    }
}
