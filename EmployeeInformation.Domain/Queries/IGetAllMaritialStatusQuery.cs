using EmployeeInformation.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Queries
{
    public interface IGetAllMaritialStatusQuery
    {
        Task<IEnumerable<Maritial>> GetAllMaritalStatus();

    }
}
