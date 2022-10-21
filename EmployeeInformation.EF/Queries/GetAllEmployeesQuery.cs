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
                IEnumerable<EmployeeDTO> employeeDTOs = await context.Employees.ToListAsync();
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
                    e.EkBilgi
                    ));
            }
        }
    }
}
