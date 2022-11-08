using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF.DTOs.Common;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInformation.EF.Queries;

public class GetAllMaritialStatusQuery : IGetAllMaritialStatusQuery
{

    readonly EmployeesDbContextFactory _contextFactory;

    public GetAllMaritialStatusQuery(EmployeesDbContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
    }


    public async Task<IEnumerable<Maritial>> GetAllMaritalStatus()
    {
        using (EmployeesDbContext context = _contextFactory.Create())
        {
            IEnumerable<MaritialDTO> maritialDTOs = await context.Maritials.ToListAsync();
            return maritialDTOs.Select(e => new Maritial(
               e.Id,
               e.MaritialStatus));
        }
    }
}
