using MvcGridView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGridView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var employees = getEmployees();
            return View(employees);
        }
        private List<Employee> getEmployees()
        {
            var list = new List<Employee>();
            
            var employee1 = new Employee();
            employee1.EmployeeID = 1;
            employee1.Name = "Diviya";
            employee1.Gender = "Female";
            employee1.City = "Chennai";

            var employee2 = new Employee();
            employee2.EmployeeID = 2;
            employee2.Name = "Pavithra";
            employee2.Gender = "Female";
            employee2.City = "Coimbatore";

            var employee3 = new Employee();
            employee3.EmployeeID = 3;
            employee3.Name = "Janani";
            employee3.Gender = "Female";
            employee3.City = "Bangalore";

            var employee4 = new Employee();
            employee4.EmployeeID = 4;
            employee4.Name = "Indhu";
            employee4.Gender = "Female";
            employee4.City = "Bangalore";

            var employee5 = new Employee();
            employee5.EmployeeID = 5;
            employee5.Name = "Kaaviyah";
            employee5.Gender = "Female";
            employee5.City = "Bangalore";

            var employee6 = new Employee();
            employee6.EmployeeID = 6;
            employee6.Name = "Shilpa";
            employee6.Gender = "Female";
            employee6.City = "Coimbatore";

            var employee7 = new Employee();
            employee7.EmployeeID = 7;
            employee7.Name = "Supiya";
            employee7.Gender = "Female";
            employee7.City = "Bangalore";

            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);
            list.Add(employee4);
            list.Add(employee5);
            list.Add(employee6);
            list.Add(employee7);

            return list;
        }
        
    }
}