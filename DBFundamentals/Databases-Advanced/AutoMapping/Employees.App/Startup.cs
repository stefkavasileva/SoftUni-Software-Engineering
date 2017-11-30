using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Employees.Data;
using Employees.Services;
using AutoMapper;

namespace Employees.App
{
    public class Startup
    {
        static void Main()
        {
            var serviceProvider = ConfigureServices();
            var engine = new Engine(serviceProvider);
            engine.Run();
        }

        public static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<EmployeesContext>
                (options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<DbInitializerService, DbInitializerService>();
            serviceCollection.AddTransient<EmployeeService>();

            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<AutomapperProfile>());
            return serviceCollection.BuildServiceProvider();
        }
    }
}
