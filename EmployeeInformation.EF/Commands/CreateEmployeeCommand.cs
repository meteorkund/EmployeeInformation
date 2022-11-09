using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF.DTOs;

namespace EmployeeInformation.EF.Commands;

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

                DepartmentDTOId = employee.Departman.Id,
                SectorDTOId = employee.Sector.Id,
                EducationDTOId = employee.Education.Id,
                MilitaryServiceDTOId =employee.Military.Id,
                MaritialDTOId = employee.Maritial.Id,


                Gorev = employee.Gorev,
                IseGiris = employee.IseGiris,
                IstenCikis = employee.IstenCikis,
                Maas = employee.Maas,
                CepTel = employee.CepTel,
                CalismaSuresi = employee.CalismaSuresi,
                BaslamaTarihi = employee.BaslamaTarihi,
                Adres = employee.Adres,
                EkBilgi = employee.EkBilgi,                   



                Vacation2018DTO = new Vacation2018DTO()
                {
                    Ocak2018_C1 = 0,
                    Ocak2018_C2 = 0,
                    Ocak2018_C3 = 0,
                    Ocak2018_C4 = 0,
                    Ocak2018_C5 = 0,
                    Ocak2018_C6 = 0,

                    Subat2018_C1 = 0,
                    Subat2018_C2 = 0,
                    Subat2018_C3 = 0,
                    Subat2018_C4 = 0,
                    Subat2018_C5 = 0,
                    Subat2018_C6 = 0,

                    Mart2018_C1 = 0,
                    Mart2018_C2 = 0,
                    Mart2018_C3 = 0,
                    Mart2018_C4 = 0,
                    Mart2018_C5 = 0,
                    Mart2018_C6 = 0,

                    Nisan2018_C1 = 0,
                    Nisan2018_C2 = 0,
                    Nisan2018_C3 = 0,
                    Nisan2018_C4 = 0,
                    Nisan2018_C5 = 0,
                    Nisan2018_C6 = 0,

                    Mayis2018_C1 = 0,
                    Mayis2018_C2 = 0,
                    Mayis2018_C3 = 0,
                    Mayis2018_C4 = 0,
                    Mayis2018_C5 = 0,
                    Mayis2018_C6 = 0,

                    Haziran2018_C1 = 0,
                    Haziran2018_C2 = 0,
                    Haziran2018_C3 = 0,
                    Haziran2018_C4 = 0,
                    Haziran2018_C5 = 0,
                    Haziran2018_C6 = 0,

                    Temmuz2018_C1 = 0,
                    Temmuz2018_C2 = 0,
                    Temmuz2018_C3 = 0,
                    Temmuz2018_C4 = 0,
                    Temmuz2018_C5 = 0,
                    Temmuz2018_C6 = 0,

                    Agustos2018_C1 = 0,
                    Agustos2018_C2 = 0,
                    Agustos2018_C3 = 0,
                    Agustos2018_C4 = 0,
                    Agustos2018_C5 = 0,
                    Agustos2018_C6 = 0,

                    Eylul2018_C1 = 0,
                    Eylul2018_C2 = 0,
                    Eylul2018_C3 = 0,
                    Eylul2018_C4 = 0,
                    Eylul2018_C5 = 0,
                    Eylul2018_C6 = 0,

                    Ekim2018_C1 = 0,
                    Ekim2018_C2 = 0,
                    Ekim2018_C3 = 0,
                    Ekim2018_C4 = 0,
                    Ekim2018_C5 = 0,
                    Ekim2018_C6 = 0,

                    Kasim2018_C1 = 0,
                    Kasim2018_C2 = 0,
                    Kasim2018_C3 = 0,
                    Kasim2018_C4 = 0,
                    Kasim2018_C5 = 0,
                    Kasim2018_C6 = 0,

                    Aralik2018_C1 = 0,
                    Aralik2018_C2 = 0,
                    Aralik2018_C3 = 0,
                    Aralik2018_C4 = 0,
                    Aralik2018_C5 = 0,
                    Aralik2018_C6 = 0,

                },
                Vacation2019DTO = new Vacation2019DTO()
                {
                    Ocak2019_C1 = 0,
                    Ocak2019_C2 = 0,
                    Ocak2019_C3 = 0,
                    Ocak2019_C4 = 0,
                    Ocak2019_C5 = 0,
                    Ocak2019_C6 = 0,

                    Subat2019_C1 = 0,
                    Subat2019_C2 = 0,
                    Subat2019_C3 = 0,
                    Subat2019_C4 = 0,
                    Subat2019_C5 = 0,
                    Subat2019_C6 = 0,

                    Mart2019_C1 = 0,
                    Mart2019_C2 = 0,
                    Mart2019_C3 = 0,
                    Mart2019_C4 = 0,
                    Mart2019_C5 = 0,
                    Mart2019_C6 = 0,

                    Nisan2019_C1 = 0,
                    Nisan2019_C2 = 0,
                    Nisan2019_C3 = 0,
                    Nisan2019_C4 = 0,
                    Nisan2019_C5 = 0,
                    Nisan2019_C6 = 0,

                    Mayis2019_C1 = 0,
                    Mayis2019_C2 = 0,
                    Mayis2019_C3 = 0,
                    Mayis2019_C4 = 0,
                    Mayis2019_C5 = 0,
                    Mayis2019_C6 = 0,

                    Haziran2019_C1 = 0,
                    Haziran2019_C2 = 0,
                    Haziran2019_C3 = 0,
                    Haziran2019_C4 = 0,
                    Haziran2019_C5 = 0,
                    Haziran2019_C6 = 0,

                    Temmuz2019_C1 = 0,
                    Temmuz2019_C2 = 0,
                    Temmuz2019_C3 = 0,
                    Temmuz2019_C4 = 0,
                    Temmuz2019_C5 = 0,
                    Temmuz2019_C6 = 0,

                    Agustos2019_C1 = 0,
                    Agustos2019_C2 = 0,
                    Agustos2019_C3 = 0,
                    Agustos2019_C4 = 0,
                    Agustos2019_C5 = 0,
                    Agustos2019_C6 = 0,

                    Eylul2019_C1 = 0,
                    Eylul2019_C2 = 0,
                    Eylul2019_C3 = 0,
                    Eylul2019_C4 = 0,
                    Eylul2019_C5 = 0,
                    Eylul2019_C6 = 0,

                    Ekim2019_C1 = 0,
                    Ekim2019_C2 = 0,
                    Ekim2019_C3 = 0,
                    Ekim2019_C4 = 0,
                    Ekim2019_C5 = 0,
                    Ekim2019_C6 = 0,

                    Kasim2019_C1 = 0,
                    Kasim2019_C2 = 0,
                    Kasim2019_C3 = 0,
                    Kasim2019_C4 = 0,
                    Kasim2019_C5 = 0,
                    Kasim2019_C6 = 0,

                    Aralik2019_C1 = 0,
                    Aralik2019_C2 = 0,
                    Aralik2019_C3 = 0,
                    Aralik2019_C4 = 0,
                    Aralik2019_C5 = 0,
                    Aralik2019_C6 = 0,

                },
                Vacation2020DTO = new Vacation2020DTO()
                {
                    Ocak2020_C1 = 0,
                    Ocak2020_C2 = 0,
                    Ocak2020_C3 = 0,
                    Ocak2020_C4 = 0,
                    Ocak2020_C5 = 0,
                    Ocak2020_C6 = 0,

                    Subat2020_C1 = 0,
                    Subat2020_C2 = 0,
                    Subat2020_C3 = 0,
                    Subat2020_C4 = 0,
                    Subat2020_C5 = 0,
                    Subat2020_C6 = 0,

                    Mart2020_C1 = 0,
                    Mart2020_C2 = 0,
                    Mart2020_C3 = 0,
                    Mart2020_C4 = 0,
                    Mart2020_C5 = 0,
                    Mart2020_C6 = 0,

                    Nisan2020_C1 = 0,
                    Nisan2020_C2 = 0,
                    Nisan2020_C3 = 0,
                    Nisan2020_C4 = 0,
                    Nisan2020_C5 = 0,
                    Nisan2020_C6 = 0,

                    Mayis2020_C1 = 0,
                    Mayis2020_C2 = 0,
                    Mayis2020_C3 = 0,
                    Mayis2020_C4 = 0,
                    Mayis2020_C5 = 0,
                    Mayis2020_C6 = 0,

                    Haziran2020_C1 = 0,
                    Haziran2020_C2 = 0,
                    Haziran2020_C3 = 0,
                    Haziran2020_C4 = 0,
                    Haziran2020_C5 = 0,
                    Haziran2020_C6 = 0,

                    Temmuz2020_C1 = 0,
                    Temmuz2020_C2 = 0,
                    Temmuz2020_C3 = 0,
                    Temmuz2020_C4 = 0,
                    Temmuz2020_C5 = 0,
                    Temmuz2020_C6 = 0,

                    Agustos2020_C1 = 0,
                    Agustos2020_C2 = 0,
                    Agustos2020_C3 = 0,
                    Agustos2020_C4 = 0,
                    Agustos2020_C5 = 0,
                    Agustos2020_C6 = 0,

                    Eylul2020_C1 = 0,
                    Eylul2020_C2 = 0,
                    Eylul2020_C3 = 0,
                    Eylul2020_C4 = 0,
                    Eylul2020_C5 = 0,
                    Eylul2020_C6 = 0,

                    Ekim2020_C1 = 0,
                    Ekim2020_C2 = 0,
                    Ekim2020_C3 = 0,
                    Ekim2020_C4 = 0,
                    Ekim2020_C5 = 0,
                    Ekim2020_C6 = 0,

                    Kasim2020_C1 = 0,
                    Kasim2020_C2 = 0,
                    Kasim2020_C3 = 0,
                    Kasim2020_C4 = 0,
                    Kasim2020_C5 = 0,
                    Kasim2020_C6 = 0,

                    Aralik2020_C1 = 0,
                    Aralik2020_C2 = 0,
                    Aralik2020_C3 = 0,
                    Aralik2020_C4 = 0,
                    Aralik2020_C5 = 0,
                    Aralik2020_C6 = 0,

                },
                Vacation2021DTO = new Vacation2021DTO()
                {
                    Ocak2021_C1 = 0,
                    Ocak2021_C2 = 0,
                    Ocak2021_C3 = 0,
                    Ocak2021_C4 = 0,
                    Ocak2021_C5 = 0,
                    Ocak2021_C6 = 0,

                    Subat2021_C1 = 0,
                    Subat2021_C2 = 0,
                    Subat2021_C3 = 0,
                    Subat2021_C4 = 0,
                    Subat2021_C5 = 0,
                    Subat2021_C6 = 0,

                    Mart2021_C1 = 0,
                    Mart2021_C2 = 0,
                    Mart2021_C3 = 0,
                    Mart2021_C4 = 0,
                    Mart2021_C5 = 0,
                    Mart2021_C6 = 0,

                    Nisan2021_C1 = 0,
                    Nisan2021_C2 = 0,
                    Nisan2021_C3 = 0,
                    Nisan2021_C4 = 0,
                    Nisan2021_C5 = 0,
                    Nisan2021_C6 = 0,

                    Mayis2021_C1 = 0,
                    Mayis2021_C2 = 0,
                    Mayis2021_C3 = 0,
                    Mayis2021_C4 = 0,
                    Mayis2021_C5 = 0,
                    Mayis2021_C6 = 0,

                    Haziran2021_C1 = 0,
                    Haziran2021_C2 = 0,
                    Haziran2021_C3 = 0,
                    Haziran2021_C4 = 0,
                    Haziran2021_C5 = 0,
                    Haziran2021_C6 = 0,

                    Temmuz2021_C1 = 0,
                    Temmuz2021_C2 = 0,
                    Temmuz2021_C3 = 0,
                    Temmuz2021_C4 = 0,
                    Temmuz2021_C5 = 0,
                    Temmuz2021_C6 = 0,

                    Agustos2021_C1 = 0,
                    Agustos2021_C2 = 0,
                    Agustos2021_C3 = 0,
                    Agustos2021_C4 = 0,
                    Agustos2021_C5 = 0,
                    Agustos2021_C6 = 0,

                    Eylul2021_C1 = 0,
                    Eylul2021_C2 = 0,
                    Eylul2021_C3 = 0,
                    Eylul2021_C4 = 0,
                    Eylul2021_C5 = 0,
                    Eylul2021_C6 = 0,

                    Ekim2021_C1 = 0,
                    Ekim2021_C2 = 0,
                    Ekim2021_C3 = 0,
                    Ekim2021_C4 = 0,
                    Ekim2021_C5 = 0,
                    Ekim2021_C6 = 0,

                    Kasim2021_C1 = 0,
                    Kasim2021_C2 = 0,
                    Kasim2021_C3 = 0,
                    Kasim2021_C4 = 0,
                    Kasim2021_C5 = 0,
                    Kasim2021_C6 = 0,

                    Aralik2021_C1 = 0,
                    Aralik2021_C2 = 0,
                    Aralik2021_C3 = 0,
                    Aralik2021_C4 = 0,
                    Aralik2021_C5 = 0,
                    Aralik2021_C6 = 0,

                },
                Vacation2022DTO = new Vacation2022DTO()
                {
                    Ocak2022_C1 = 0,
                    Ocak2022_C2 = 0,
                    Ocak2022_C3 = 0,
                    Ocak2022_C4 = 0,
                    Ocak2022_C5 = 0,
                    Ocak2022_C6 = 0,

                    Subat2022_C1 = 0,
                    Subat2022_C2 = 0,
                    Subat2022_C3 = 0,
                    Subat2022_C4 = 0,
                    Subat2022_C5 = 0,
                    Subat2022_C6 = 0,

                    Mart2022_C1 = 0,
                    Mart2022_C2 = 0,
                    Mart2022_C3 = 0,
                    Mart2022_C4 = 0,
                    Mart2022_C5 = 0,
                    Mart2022_C6 = 0,

                    Nisan2022_C1 = 0,
                    Nisan2022_C2 = 0,
                    Nisan2022_C3 = 0,
                    Nisan2022_C4 = 0,
                    Nisan2022_C5 = 0,
                    Nisan2022_C6 = 0,

                    Mayis2022_C1 = 0,
                    Mayis2022_C2 = 0,
                    Mayis2022_C3 = 0,
                    Mayis2022_C4 = 0,
                    Mayis2022_C5 = 0,
                    Mayis2022_C6 = 0,

                    Haziran2022_C1 = 0,
                    Haziran2022_C2 = 0,
                    Haziran2022_C3 = 0,
                    Haziran2022_C4 = 0,
                    Haziran2022_C5 = 0,
                    Haziran2022_C6 = 0,

                    Temmuz2022_C1 = 0,
                    Temmuz2022_C2 = 0,
                    Temmuz2022_C3 = 0,
                    Temmuz2022_C4 = 0,
                    Temmuz2022_C5 = 0,
                    Temmuz2022_C6 = 0,

                    Agustos2022_C1 = 0,
                    Agustos2022_C2 = 0,
                    Agustos2022_C3 = 0,
                    Agustos2022_C4 = 0,
                    Agustos2022_C5 = 0,
                    Agustos2022_C6 = 0,

                    Eylul2022_C1 = 0,
                    Eylul2022_C2 = 0,
                    Eylul2022_C3 = 0,
                    Eylul2022_C4 = 0,
                    Eylul2022_C5 = 0,
                    Eylul2022_C6 = 0,

                    Ekim2022_C1 = 0,
                    Ekim2022_C2 = 0,
                    Ekim2022_C3 = 0,
                    Ekim2022_C4 = 0,
                    Ekim2022_C5 = 0,
                    Ekim2022_C6 = 0,

                    Kasim2022_C1 = 0,
                    Kasim2022_C2 = 0,
                    Kasim2022_C3 = 0,
                    Kasim2022_C4 = 0,
                    Kasim2022_C5 = 0,
                    Kasim2022_C6 = 0,

                    Aralik2022_C1 = 0,
                    Aralik2022_C2 = 0,
                    Aralik2022_C3 = 0,
                    Aralik2022_C4 = 0,
                    Aralik2022_C5 = 0,
                    Aralik2022_C6 = 0,

                },
                Vacation2023DTO = new Vacation2023DTO()
                {
                    Ocak2023_C1 = 0,
                    Ocak2023_C2 = 0,
                    Ocak2023_C3 = 0,
                    Ocak2023_C4 = 0,
                    Ocak2023_C5 = 0,
                    Ocak2023_C6 = 0,

                    Subat2023_C1 = 0,
                    Subat2023_C2 = 0,
                    Subat2023_C3 = 0,
                    Subat2023_C4 = 0,
                    Subat2023_C5 = 0,
                    Subat2023_C6 = 0,

                    Mart2023_C1 = 0,
                    Mart2023_C2 = 0,
                    Mart2023_C3 = 0,
                    Mart2023_C4 = 0,
                    Mart2023_C5 = 0,
                    Mart2023_C6 = 0,

                    Nisan2023_C1 = 0,
                    Nisan2023_C2 = 0,
                    Nisan2023_C3 = 0,
                    Nisan2023_C4 = 0,
                    Nisan2023_C5 = 0,
                    Nisan2023_C6 = 0,

                    Mayis2023_C1 = 0,
                    Mayis2023_C2 = 0,
                    Mayis2023_C3 = 0,
                    Mayis2023_C4 = 0,
                    Mayis2023_C5 = 0,
                    Mayis2023_C6 = 0,

                    Haziran2023_C1 = 0,
                    Haziran2023_C2 = 0,
                    Haziran2023_C3 = 0,
                    Haziran2023_C4 = 0,
                    Haziran2023_C5 = 0,
                    Haziran2023_C6 = 0,

                    Temmuz2023_C1 = 0,
                    Temmuz2023_C2 = 0,
                    Temmuz2023_C3 = 0,
                    Temmuz2023_C4 = 0,
                    Temmuz2023_C5 = 0,
                    Temmuz2023_C6 = 0,

                    Agustos2023_C1 = 0,
                    Agustos2023_C2 = 0,
                    Agustos2023_C3 = 0,
                    Agustos2023_C4 = 0,
                    Agustos2023_C5 = 0,
                    Agustos2023_C6 = 0,

                    Eylul2023_C1 = 0,
                    Eylul2023_C2 = 0,
                    Eylul2023_C3 = 0,
                    Eylul2023_C4 = 0,
                    Eylul2023_C5 = 0,
                    Eylul2023_C6 = 0,

                    Ekim2023_C1 = 0,
                    Ekim2023_C2 = 0,
                    Ekim2023_C3 = 0,
                    Ekim2023_C4 = 0,
                    Ekim2023_C5 = 0,
                    Ekim2023_C6 = 0,

                    Kasim2023_C1 = 0,
                    Kasim2023_C2 = 0,
                    Kasim2023_C3 = 0,
                    Kasim2023_C4 = 0,
                    Kasim2023_C5 = 0,
                    Kasim2023_C6 = 0,

                    Aralik2023_C1 = 0,
                    Aralik2023_C2 = 0,
                    Aralik2023_C3 = 0,
                    Aralik2023_C4 = 0,
                    Aralik2023_C5 = 0,
                    Aralik2023_C6 = 0,
                }

            };

            context.Employees.Add(employeeDTOs);
            await context.SaveChangesAsync();
        }
    }
}
