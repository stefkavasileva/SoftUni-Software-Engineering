using System.Collections.Generic;

namespace Employees.DtoModels
{
    public class ManagerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SubordinatesCount => this.Subordinates.Count;

        public ICollection<EmployeeDto> Subordinates { get; set; } = new List<EmployeeDto>();
    }
}