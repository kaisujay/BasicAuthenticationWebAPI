using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWebAPI.Models
{
    public class EmployeeBL
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee{ID = 1 , Name = "Sujay" , Dept = "IT" , Salary = 1000, Gender = "Male"},
                new Employee{ID = 2 , Name = "Nikki" , Dept = "HR" , Salary = 1500, Gender = "Female"},
                new Employee{ID = 3 , Name = "Sunny" , Dept = "IT" , Salary = 2000, Gender = "Male"},
                new Employee{ID = 4 , Name = "Ajay" , Dept = "HR" , Salary = 500, Gender = "Male"},
                new Employee{ID = 5 , Name = "Mannu" , Dept = "IT" , Salary = 1500, Gender = "Female"},
            };

            return employeeList;
        }
    }
}