using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Models.Common
{
    public class Department
    {
        public int Id { get; }
        public string DepartmentName { get; }

        public Department(int id, string departmentName)
        {
            DepartmentName = departmentName;
            Id = id;
        }
    }
}
