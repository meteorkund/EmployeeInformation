using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF
{
    public class EmployeesDbContextFactory
    {
        readonly DbContextOptions _options;

        public EmployeesDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public EmployeesDbContext Create()
        {
            return new EmployeesDbContext(_options);
        }
    }
}
