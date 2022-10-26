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
                    e.CreatedDate,

                    new Vacation2018
                    {
                        Id = e.Id,
                        Ocak2018_C1 = e.Vacation2018DTO.Ocak2018_C1,
                        Ocak2018_C2 = e.Vacation2018DTO.Ocak2018_C2,
                        Ocak2018_C3 = e.Vacation2018DTO.Ocak2018_C3,
                        Ocak2018_C4 = e.Vacation2018DTO.Ocak2018_C4,
                        Ocak2018_C5 = e.Vacation2018DTO.Ocak2018_C5,
                        Ocak2018_C6 = e.Vacation2018DTO.Ocak2018_C6,

                        Subat2018_C1 = e.Vacation2018DTO.Subat2018_C1,
                        Subat2018_C2 = e.Vacation2018DTO.Subat2018_C2,
                        Subat2018_C3 = e.Vacation2018DTO.Subat2018_C3,
                        Subat2018_C4 = e.Vacation2018DTO.Subat2018_C4,
                        Subat2018_C5 = e.Vacation2018DTO.Subat2018_C5,
                        Subat2018_C6 = e.Vacation2018DTO.Subat2018_C6,

                        Mart2018_C1 = e.Vacation2018DTO.Mart2018_C1,
                        Mart2018_C2 = e.Vacation2018DTO.Mart2018_C2,
                        Mart2018_C3 = e.Vacation2018DTO.Mart2018_C3,
                        Mart2018_C4 = e.Vacation2018DTO.Mart2018_C4,
                        Mart2018_C5 = e.Vacation2018DTO.Mart2018_C5,
                        Mart2018_C6 = e.Vacation2018DTO.Mart2018_C6,

                        Nisan2018_C1 = e.Vacation2018DTO.Nisan2018_C1,
                        Nisan2018_C2 = e.Vacation2018DTO.Nisan2018_C2,
                        Nisan2018_C3 = e.Vacation2018DTO.Nisan2018_C3,
                        Nisan2018_C4 = e.Vacation2018DTO.Nisan2018_C4,
                        Nisan2018_C5 = e.Vacation2018DTO.Nisan2018_C5,
                        Nisan2018_C6 = e.Vacation2018DTO.Nisan2018_C6,

                        Mayis2018_C1 = e.Vacation2018DTO.Mayis2018_C1,
                        Mayis2018_C2 = e.Vacation2018DTO.Mayis2018_C2,
                        Mayis2018_C3 = e.Vacation2018DTO.Mayis2018_C3,
                        Mayis2018_C4 = e.Vacation2018DTO.Mayis2018_C4,
                        Mayis2018_C5 = e.Vacation2018DTO.Mayis2018_C5,
                        Mayis2018_C6 = e.Vacation2018DTO.Mayis2018_C6,

                        Haziran2018_C1 = e.Vacation2018DTO.Haziran2018_C1,
                        Haziran2018_C2 = e.Vacation2018DTO.Haziran2018_C2,
                        Haziran2018_C3 = e.Vacation2018DTO.Haziran2018_C3,
                        Haziran2018_C4 = e.Vacation2018DTO.Haziran2018_C4,
                        Haziran2018_C5 = e.Vacation2018DTO.Haziran2018_C5,
                        Haziran2018_C6 = e.Vacation2018DTO.Haziran2018_C6,

                        Temmuz2018_C1 = e.Vacation2018DTO.Temmuz2018_C1,
                        Temmuz2018_C2 = e.Vacation2018DTO.Temmuz2018_C2,
                        Temmuz2018_C3 = e.Vacation2018DTO.Temmuz2018_C3,
                        Temmuz2018_C4 = e.Vacation2018DTO.Temmuz2018_C4,
                        Temmuz2018_C5 = e.Vacation2018DTO.Temmuz2018_C5,
                        Temmuz2018_C6 = e.Vacation2018DTO.Temmuz2018_C6,

                        Agustos2018_C1 = e.Vacation2018DTO.Agustos2018_C1,
                        Agustos2018_C2 = e.Vacation2018DTO.Agustos2018_C2,
                        Agustos2018_C3 = e.Vacation2018DTO.Agustos2018_C3,
                        Agustos2018_C4 = e.Vacation2018DTO.Agustos2018_C4,
                        Agustos2018_C5 = e.Vacation2018DTO.Agustos2018_C5,
                        Agustos2018_C6 = e.Vacation2018DTO.Agustos2018_C6,

                        Eylul2018_C1 = e.Vacation2018DTO.Eylul2018_C1,
                        Eylul2018_C2 = e.Vacation2018DTO.Eylul2018_C2,
                        Eylul2018_C3 = e.Vacation2018DTO.Eylul2018_C3,
                        Eylul2018_C4 = e.Vacation2018DTO.Eylul2018_C4,
                        Eylul2018_C5 = e.Vacation2018DTO.Eylul2018_C5,
                        Eylul2018_C6 = e.Vacation2018DTO.Eylul2018_C6,

                        Ekim2018_C1 = e.Vacation2018DTO.Ekim2018_C1,
                        Ekim2018_C2 = e.Vacation2018DTO.Ekim2018_C2,
                        Ekim2018_C3 = e.Vacation2018DTO.Ekim2018_C3,
                        Ekim2018_C4 = e.Vacation2018DTO.Ekim2018_C4,
                        Ekim2018_C5 = e.Vacation2018DTO.Ekim2018_C5,
                        Ekim2018_C6 = e.Vacation2018DTO.Ekim2018_C6,

                        Kasim2018_C1 = e.Vacation2018DTO.Kasim2018_C1,
                        Kasim2018_C2 = e.Vacation2018DTO.Kasim2018_C2,
                        Kasim2018_C3 = e.Vacation2018DTO.Kasim2018_C3,
                        Kasim2018_C4 = e.Vacation2018DTO.Kasim2018_C4,
                        Kasim2018_C5 = e.Vacation2018DTO.Kasim2018_C5,
                        Kasim2018_C6 = e.Vacation2018DTO.Kasim2018_C6,

                        Aralik2018_C1 = e.Vacation2018DTO.Aralik2018_C1,
                        Aralik2018_C2 = e.Vacation2018DTO.Aralik2018_C2,
                        Aralik2018_C3 = e.Vacation2018DTO.Aralik2018_C3,
                        Aralik2018_C4 = e.Vacation2018DTO.Aralik2018_C4,
                        Aralik2018_C5 = e.Vacation2018DTO.Aralik2018_C5,
                        Aralik2018_C6 = e.Vacation2018DTO.Aralik2018_C6,

                    }));
            }
        }
    }
}
