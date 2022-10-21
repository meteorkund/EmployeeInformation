using EmployeeInformation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Queries
{
    public interface IGetAllEmployeesQuery
    {
        Task<IEnumerable<Employee>> Execute();
    }
}
