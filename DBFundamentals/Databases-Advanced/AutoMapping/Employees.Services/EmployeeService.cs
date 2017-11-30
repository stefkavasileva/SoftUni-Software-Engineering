using Employees.Data;
using Employees.DtoModels;
using Employees.Models;
using AutoMapper;
using System;

namespace Employees.Services
{
    public class EmployeeService
    {
        private readonly EmployeesContext context;

        public EmployeeService(EmployeesContext context)
        {
            this.context = context;
        }

        public EmployeeDto ById(int id)
        {
            var currentEmployee = context.Employees.Find(id);
            var employeeDto = Mapper.Map<EmployeeDto>(currentEmployee);

            return employeeDto;
        }

        public string AddEmployee(EmployeeDto dto)
        {
            var employee = Mapper.Map<Employee>(dto);

            context.Employees.Add(employee);

            context.SaveChanges();

            return "Added employee";
        }

        public string    SetBirthday(int employeeId , DateTime birthday)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Birthday = birthday;

            context.SaveChanges();

            return $"{employee.FirstName} {employee.LastName}";
        }

        public string SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Address = address;

            context.SaveChanges();

            return $"{employee.FirstName} {employee.LastName}";
        }

        public EmployeePersonalDto PeronalById(int id)
        {
            var currentEmployee = context.Employees.Find(id);
            var employeeDto = Mapper.Map<EmployeePersonalDto>(currentEmployee);

            return employeeDto;
        }
    } 
}
