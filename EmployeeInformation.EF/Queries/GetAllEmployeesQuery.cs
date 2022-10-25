using EmployeeInformation.Domain.Models;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.Queries
{
    public class GetAllEmployeesQuery : IGetAllEmployeesQuery
    {
        readonly EmployeesDbContextFactory _contextFactory;

        public GetAllEmployeesQuery(EmployeesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Employee>> Execute()
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {
                IEnumerable<EmployeeDTO> employeeDTOs = await context.Employees.Include(v => v.Vacation2018DTO).ToListAsync();
                return employeeDTOs.Select(e => new Employee(
                    e.Id,
                    e.Fotograf,
                    e.Isim,
                    e.Soyisim,
                    e.Durum,
                    e.TCKimlik,
                    e.DogumTarihi,
                    e.MedeniDurum,
                    e.EgitimDurumu,
                    e.Askerlik,
                    e.Departman,
                    e.Gorev,
                    e.IseGiris,
                    e.IstenCikis,
                    e.Maas,
                    e.CepTel,
                    e.CalismaSuresi,
                    e.BaslamaTarihi,
                    e.Adres,
                    e.EkBilgi,

                    new Vacation2018
                    {
                        Id = e.Id,
                        Ocak2018_c1 = (int)e.Vacation2018DTO.Ocak2018_c1,
                        Ocak2018_c2 = (int)e.Vacation2018DTO.Ocak2018_c2,
                        Ocak2018_c3 = (int)e.Vacation2018DTO.Ocak2018_c3,
                        Ocak2018_c4 = (int)e.Vacation2018DTO.Ocak2018_c4,
                        Ocak2018_c5 = (int)e.Vacation2018DTO.Ocak2018_c5,
                        Ocak2018_c6 = (int)e.Vacation2018DTO.Ocak2018_c6,

                        Subat2018_c1 = (int)e.Vacation2018DTO.Subat2018_c1,
                        Subat2018_c2 = (int)e.Vacation2018DTO.Subat2018_c2,
                        Subat2018_c3 = (int)e.Vacation2018DTO.Subat2018_c3,
                        Subat2018_c4 = (int)e.Vacation2018DTO.Subat2018_c4,
                        Subat2018_c5 = (int)e.Vacation2018DTO.Subat2018_c5,
                        Subat2018_c6 = (int)e.Vacation2018DTO.Subat2018_c6,


                    }));
            }
        }
    }
}
