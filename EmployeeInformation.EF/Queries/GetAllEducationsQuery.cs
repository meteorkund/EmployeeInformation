using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF.DTOs.Common;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInformation.EF.Queries;

public class GetAllEducationsQuery : IGetAllEducationsQuery
{
    readonly EmployeesDbContextFactory _contextFactory;

    public GetAllEducationsQuery(EmployeesDbContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<IEnumerable<Education>> GetAllEducations()
    {
        using (EmployeesDbContext context = _contextFactory.Create())
        {
            IEnumerable<EducationDTO> educationDTOs = await context.Educations.ToListAsync();
            return educationDTOs.Select(e => new Education(
               e.Id,
               e.EducationStatus));
        }
    }


}

