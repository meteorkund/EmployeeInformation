using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using Microsoft.EntityFrameworkCore;
using EmployeeInformation.EF.DTOs.Common;

namespace EmployeeInformation.EF.Queries
{
    public class GetAllSectorsQuery : IGetAllSectorsQuery
    {
        readonly EmployeesDbContextFactory _contextFactory;

        public GetAllSectorsQuery(EmployeesDbContextFactory contextFactor)
        {
            _contextFactory = contextFactor;
        }

        public async Task<IEnumerable<Sector>> GetAllSectors()
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {
                IEnumerable<SectorDTO> sectorDTOs = await context.Sectors.ToListAsync();
                return sectorDTOs.Select(d => new Sector(
                    d.Id,
                    d.SectorName
                    ));
            }
        }
    }
}
