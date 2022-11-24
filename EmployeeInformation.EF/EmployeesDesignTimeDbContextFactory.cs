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
            var connectionString = $"DataSource={Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PERSONEL_DB\\personelData.db;";

            return new EmployeesDbContext(new DbContextOptionsBuilder()
                .UseSqlite(connectionString)
                .Options);
        }
    }
}
