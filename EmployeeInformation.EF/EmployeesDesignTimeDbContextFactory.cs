using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF
{
    public class EmployeesDesignTimeDbContextFactory : IDesignTimeDbContextFactory<EmployeesDbContext>
    {
        public EmployeesDbContext CreateDbContext(string[] args)
        {
            return new EmployeesDbContext(new DbContextOptionsBuilder()
                .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EmployeeInformationDB;Trusted_Connection=True;")
                .Options);
        }
    }
}
