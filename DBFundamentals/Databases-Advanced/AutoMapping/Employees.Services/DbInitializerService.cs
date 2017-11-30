using Employees.Data;
using Microsoft.EntityFrameworkCore;

namespace Employees.Services
{
    public class DbInitializerService 
    {
        private readonly EmployeesContext context;

        public DbInitializerService(EmployeesContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.EnsureDeleted();
            this.context.Database.Migrate();
        }
    }
}