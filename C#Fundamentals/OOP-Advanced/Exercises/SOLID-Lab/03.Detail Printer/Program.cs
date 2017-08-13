using System.Collections.Generic;

namespace _03.Detail_Printer
{
    public class Program
    {
        public static void Main()
        {
            var employee = new Employee("Name");
            var manager = new Employee("Manager name");

            var printer = new DetailsPrinter(new List<Employee> { employee, manager });
            printer.printDetails();
        }
    }
}
