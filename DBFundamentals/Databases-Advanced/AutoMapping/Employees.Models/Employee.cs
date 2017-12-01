using System;
using System.Collections.Generic;

namespace Employees.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Salary { get; set; }

        public DateTime? Birthday { get; set; }

        public string Address { get; set; }

        public int? ManagerId { get; set; }

        public Employee Manager { get; set; }

        public ICollection<Employee> Subordinates { get; set; } = new List<Employee>();
    }
}
