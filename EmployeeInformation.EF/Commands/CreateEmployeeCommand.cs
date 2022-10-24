using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.Commands
{
    public class CreateEmployeeCommand : ICreateEmployeeCommand
    {
        readonly EmployeesDbContextFactory _contextFactory;

        public CreateEmployeeCommand(EmployeesDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Employee employee)
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {                

                EmployeeDTO employeeDTOs = new EmployeeDTO()
                {
                    Fotograf = employee.Fotograf,
                    Isim = employee.Isim,
                    Soyisim = employee.Soyisim,
                    Durum = employee.Durum,
                    TCKimlik = employee.TCKimlik,
                    DogumTarihi = employee.DogumTarihi,
                    MedeniDurum = employee.MedeniDurum,
                    EgitimDurumu = employee.EgitimDurumu,
                    Askerlik = employee.Askerlik,
                    Departman = employee.Departman,
                    Gorev = employee.Gorev,
                    IseGiris = employee.IseGiris,
                    IstenCikis = employee.IstenCikis,
                    Maas = employee.Maas,
                    CepTel = employee.CepTel,
                    CalismaSuresi = employee.CalismaSuresi,
                    BaslamaTarihi = employee.BaslamaTarihi,
                    Adres = employee.Adres,
                    EkBilgi = employee.EkBilgi,
                };

                context.Employees.Add(employeeDTOs);
                await context.SaveChangesAsync();
            }
        }
    }
}
