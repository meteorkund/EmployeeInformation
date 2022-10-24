using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.Commands
{
    public class DeleteEmployeeCommand : IDeleteEmployeeCommand
    {
        readonly EmployeesDbContextFactory _contextFactory;

        public DeleteEmployeeCommand(EmployeesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task Execute(int id)
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {

                EmployeeDTO employeeDTOs = new EmployeeDTO()
                {
                    Id = id,
                };

                context.Employees.Remove(employeeDTOs);
                await context.SaveChangesAsync();
            }
        }
    }
}
