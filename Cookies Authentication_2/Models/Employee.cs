using System.Collections.Generic;

namespace Cookies_Authentication_2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        public List<Employee> GetEmployees()
        {
            var result = new List<Employee>()
        {
            new Employee(){ EmployeeId = 101, Name = "Gyan Dash", Dept = "IT" },
            new Employee(){ EmployeeId = 102, Name = "Milu", Dept = "Data Analyst" },
            new Employee(){ EmployeeId = 101, Name = "Chandra", Dept = "Insurance" },
        };
            return result;
        }
    }
}
