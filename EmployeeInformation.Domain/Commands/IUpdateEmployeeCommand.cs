using EmployeeInformation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Commands
{
    public interface IUpdateEmployeeCommand
    {
        Task Execute(Employee employee);
    }
}
