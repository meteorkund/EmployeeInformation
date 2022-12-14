using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using EmployeeInformation.EF.DTOs.Common;

namespace EmployeeInformation.EF.Queries
{
    public class GetAllDepartmentsQuery : IGetAllDepartmentsQuery
    {
        readonly EmployeesDbContextFactory _contextFactory;

        public GetAllDepartmentsQuery(EmployeesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {
                IEnumerable<DepartmentDTO> departmentDTOs = await context.Departments.ToListAsync();
                return departmentDTOs.Select(d => new Department(
                    d.Id,
                    d.DepartmentName
                    ));
            }
        }
    }
}
