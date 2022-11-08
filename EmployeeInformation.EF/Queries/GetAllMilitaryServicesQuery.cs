using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using EmployeeInformation.EF.DTOs.Common;

namespace EmployeeInformation.EF.Queries
{
    public class GetAllMilitaryServicesQuery : IGetAllMilitaryServicesQuery
    {
        readonly EmployeesDbContextFactory _contextFactory;

        public GetAllMilitaryServicesQuery(EmployeesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<MilitaryServiceStatus>> GetAllMilitaries()
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {
                IEnumerable<MilitaryServiceDTO> militaryServiceDTOs = await context.MilitaryServices.ToListAsync();
                return militaryServiceDTOs.Select(d => new MilitaryServiceStatus(
                    d.Id,
                    d.MilitaryStatus
                    ));
            }
        }

    }
}
