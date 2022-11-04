using EmployeeInformation.Domain.Models;
using EmployeeInformation.Domain.Models.Common;
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

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {

                IEnumerable<EmployeeDTO> employeeDTOs = await context.Employees
                    .Include(d => d.DepartmentDTO)
                    .Include(s => s.SectorDTO)
                    .Include(v => v.Vacation2018DTO)
                    .Include(v => v.Vacation2019DTO)
                    .Include(v => v.Vacation2020DTO)
                    .Include(v => v.Vacation2021DTO)
                    .Include(v => v.Vacation2022DTO)
                    .Include(v => v.Vacation2023DTO)
                    .ToListAsync();

                employeeDTOs.Select(d => new Department(d.DepartmentDTO.Id, d.DepartmentDTO.DepartmentName));

                return employeeDTOs.Select(e => new Employee
                {
                    Id = e.Id,
                    Fotograf = e.Fotograf,
                    Isim = e.Isim,
                    Soyisim = e.Soyisim,
                    Durum = e.Durum,
                    TCKimlik = e.TCKimlik,
                    DogumTarihi = e.DogumTarihi,
                    MedeniDurum = e.MedeniDurum,
                    EgitimDurumu = e.EgitimDurumu,
                    Askerlik = e.Askerlik,
                    Gorev = e.Gorev,
                    IseGiris = e.IseGiris,
                    IstenCikis = e.IstenCikis,
                    Maas = e.Maas,
                    CepTel = e.CepTel,
                    CalismaSuresi = e.CalismaSuresi,
                    BaslamaTarihi = e.BaslamaTarihi,
                    Adres = e.Adres,
                    EkBilgi = e.EkBilgi,
                    CreatedDate = e.CreatedDate,

                    Departman = new Department(e.DepartmentDTO.Id, e.DepartmentDTO.DepartmentName),
                    Sector = new Sector(e.SectorDTO.Id, e.SectorDTO.SectorName),

                    Vacation2018 = new Vacation2018
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
                    },
                    Vacation2019 = new Vacation2019
                    {
                        Id = e.Id,
                        Ocak2019_C1 = e.Vacation2019DTO.Ocak2019_C1,
                        Ocak2019_C2 = e.Vacation2019DTO.Ocak2019_C2,
                        Ocak2019_C3 = e.Vacation2019DTO.Ocak2019_C3,
                        Ocak2019_C4 = e.Vacation2019DTO.Ocak2019_C4,
                        Ocak2019_C5 = e.Vacation2019DTO.Ocak2019_C5,
                        Ocak2019_C6 = e.Vacation2019DTO.Ocak2019_C6,

                        Subat2019_C1 = e.Vacation2019DTO.Subat2019_C1,
                        Subat2019_C2 = e.Vacation2019DTO.Subat2019_C2,
                        Subat2019_C3 = e.Vacation2019DTO.Subat2019_C3,
                        Subat2019_C4 = e.Vacation2019DTO.Subat2019_C4,
                        Subat2019_C5 = e.Vacation2019DTO.Subat2019_C5,
                        Subat2019_C6 = e.Vacation2019DTO.Subat2019_C6,

                        Mart2019_C1 = e.Vacation2019DTO.Mart2019_C1,
                        Mart2019_C2 = e.Vacation2019DTO.Mart2019_C2,
                        Mart2019_C3 = e.Vacation2019DTO.Mart2019_C3,
                        Mart2019_C4 = e.Vacation2019DTO.Mart2019_C4,
                        Mart2019_C5 = e.Vacation2019DTO.Mart2019_C5,
                        Mart2019_C6 = e.Vacation2019DTO.Mart2019_C6,

                        Nisan2019_C1 = e.Vacation2019DTO.Nisan2019_C1,
                        Nisan2019_C2 = e.Vacation2019DTO.Nisan2019_C2,
                        Nisan2019_C3 = e.Vacation2019DTO.Nisan2019_C3,
                        Nisan2019_C4 = e.Vacation2019DTO.Nisan2019_C4,
                        Nisan2019_C5 = e.Vacation2019DTO.Nisan2019_C5,
                        Nisan2019_C6 = e.Vacation2019DTO.Nisan2019_C6,

                        Mayis2019_C1 = e.Vacation2019DTO.Mayis2019_C1,
                        Mayis2019_C2 = e.Vacation2019DTO.Mayis2019_C2,
                        Mayis2019_C3 = e.Vacation2019DTO.Mayis2019_C3,
                        Mayis2019_C4 = e.Vacation2019DTO.Mayis2019_C4,
                        Mayis2019_C5 = e.Vacation2019DTO.Mayis2019_C5,
                        Mayis2019_C6 = e.Vacation2019DTO.Mayis2019_C6,

                        Haziran2019_C1 = e.Vacation2019DTO.Haziran2019_C1,
                        Haziran2019_C2 = e.Vacation2019DTO.Haziran2019_C2,
                        Haziran2019_C3 = e.Vacation2019DTO.Haziran2019_C3,
                        Haziran2019_C4 = e.Vacation2019DTO.Haziran2019_C4,
                        Haziran2019_C5 = e.Vacation2019DTO.Haziran2019_C5,
                        Haziran2019_C6 = e.Vacation2019DTO.Haziran2019_C6,

                        Temmuz2019_C1 = e.Vacation2019DTO.Temmuz2019_C1,
                        Temmuz2019_C2 = e.Vacation2019DTO.Temmuz2019_C2,
                        Temmuz2019_C3 = e.Vacation2019DTO.Temmuz2019_C3,
                        Temmuz2019_C4 = e.Vacation2019DTO.Temmuz2019_C4,
                        Temmuz2019_C5 = e.Vacation2019DTO.Temmuz2019_C5,
                        Temmuz2019_C6 = e.Vacation2019DTO.Temmuz2019_C6,

                        Agustos2019_C1 = e.Vacation2019DTO.Agustos2019_C1,
                        Agustos2019_C2 = e.Vacation2019DTO.Agustos2019_C2,
                        Agustos2019_C3 = e.Vacation2019DTO.Agustos2019_C3,
                        Agustos2019_C4 = e.Vacation2019DTO.Agustos2019_C4,
                        Agustos2019_C5 = e.Vacation2019DTO.Agustos2019_C5,
                        Agustos2019_C6 = e.Vacation2019DTO.Agustos2019_C6,

                        Eylul2019_C1 = e.Vacation2019DTO.Eylul2019_C1,
                        Eylul2019_C2 = e.Vacation2019DTO.Eylul2019_C2,
                        Eylul2019_C3 = e.Vacation2019DTO.Eylul2019_C3,
                        Eylul2019_C4 = e.Vacation2019DTO.Eylul2019_C4,
                        Eylul2019_C5 = e.Vacation2019DTO.Eylul2019_C5,
                        Eylul2019_C6 = e.Vacation2019DTO.Eylul2019_C6,

                        Ekim2019_C1 = e.Vacation2019DTO.Ekim2019_C1,
                        Ekim2019_C2 = e.Vacation2019DTO.Ekim2019_C2,
                        Ekim2019_C3 = e.Vacation2019DTO.Ekim2019_C3,
                        Ekim2019_C4 = e.Vacation2019DTO.Ekim2019_C4,
                        Ekim2019_C5 = e.Vacation2019DTO.Ekim2019_C5,
                        Ekim2019_C6 = e.Vacation2019DTO.Ekim2019_C6,

                        Kasim2019_C1 = e.Vacation2019DTO.Kasim2019_C1,
                        Kasim2019_C2 = e.Vacation2019DTO.Kasim2019_C2,
                        Kasim2019_C3 = e.Vacation2019DTO.Kasim2019_C3,
                        Kasim2019_C4 = e.Vacation2019DTO.Kasim2019_C4,
                        Kasim2019_C5 = e.Vacation2019DTO.Kasim2019_C5,
                        Kasim2019_C6 = e.Vacation2019DTO.Kasim2019_C6,

                        Aralik2019_C1 = e.Vacation2019DTO.Aralik2019_C1,
                        Aralik2019_C2 = e.Vacation2019DTO.Aralik2019_C2,
                        Aralik2019_C3 = e.Vacation2019DTO.Aralik2019_C3,
                        Aralik2019_C4 = e.Vacation2019DTO.Aralik2019_C4,
                        Aralik2019_C5 = e.Vacation2019DTO.Aralik2019_C5,
                        Aralik2019_C6 = e.Vacation2019DTO.Aralik2019_C6,
                    },
                    Vacation2020 = new Vacation2020
                    {
                        Id = e.Id,
                        Ocak2020_C1 = e.Vacation2020DTO.Ocak2020_C1,
                        Ocak2020_C2 = e.Vacation2020DTO.Ocak2020_C2,
                        Ocak2020_C3 = e.Vacation2020DTO.Ocak2020_C3,
                        Ocak2020_C4 = e.Vacation2020DTO.Ocak2020_C4,
                        Ocak2020_C5 = e.Vacation2020DTO.Ocak2020_C5,
                        Ocak2020_C6 = e.Vacation2020DTO.Ocak2020_C6,

                        Subat2020_C1 = e.Vacation2020DTO.Subat2020_C1,
                        Subat2020_C2 = e.Vacation2020DTO.Subat2020_C2,
                        Subat2020_C3 = e.Vacation2020DTO.Subat2020_C3,
                        Subat2020_C4 = e.Vacation2020DTO.Subat2020_C4,
                        Subat2020_C5 = e.Vacation2020DTO.Subat2020_C5,
                        Subat2020_C6 = e.Vacation2020DTO.Subat2020_C6,

                        Mart2020_C1 = e.Vacation2020DTO.Mart2020_C1,
                        Mart2020_C2 = e.Vacation2020DTO.Mart2020_C2,
                        Mart2020_C3 = e.Vacation2020DTO.Mart2020_C3,
                        Mart2020_C4 = e.Vacation2020DTO.Mart2020_C4,
                        Mart2020_C5 = e.Vacation2020DTO.Mart2020_C5,
                        Mart2020_C6 = e.Vacation2020DTO.Mart2020_C6,

                        Nisan2020_C1 = e.Vacation2020DTO.Nisan2020_C1,
                        Nisan2020_C2 = e.Vacation2020DTO.Nisan2020_C2,
                        Nisan2020_C3 = e.Vacation2020DTO.Nisan2020_C3,
                        Nisan2020_C4 = e.Vacation2020DTO.Nisan2020_C4,
                        Nisan2020_C5 = e.Vacation2020DTO.Nisan2020_C5,
                        Nisan2020_C6 = e.Vacation2020DTO.Nisan2020_C6,

                        Mayis2020_C1 = e.Vacation2020DTO.Mayis2020_C1,
                        Mayis2020_C2 = e.Vacation2020DTO.Mayis2020_C2,
                        Mayis2020_C3 = e.Vacation2020DTO.Mayis2020_C3,
                        Mayis2020_C4 = e.Vacation2020DTO.Mayis2020_C4,
                        Mayis2020_C5 = e.Vacation2020DTO.Mayis2020_C5,
                        Mayis2020_C6 = e.Vacation2020DTO.Mayis2020_C6,

                        Haziran2020_C1 = e.Vacation2020DTO.Haziran2020_C1,
                        Haziran2020_C2 = e.Vacation2020DTO.Haziran2020_C2,
                        Haziran2020_C3 = e.Vacation2020DTO.Haziran2020_C3,
                        Haziran2020_C4 = e.Vacation2020DTO.Haziran2020_C4,
                        Haziran2020_C5 = e.Vacation2020DTO.Haziran2020_C5,
                        Haziran2020_C6 = e.Vacation2020DTO.Haziran2020_C6,

                        Temmuz2020_C1 = e.Vacation2020DTO.Temmuz2020_C1,
                        Temmuz2020_C2 = e.Vacation2020DTO.Temmuz2020_C2,
                        Temmuz2020_C3 = e.Vacation2020DTO.Temmuz2020_C3,
                        Temmuz2020_C4 = e.Vacation2020DTO.Temmuz2020_C4,
                        Temmuz2020_C5 = e.Vacation2020DTO.Temmuz2020_C5,
                        Temmuz2020_C6 = e.Vacation2020DTO.Temmuz2020_C6,

                        Agustos2020_C1 = e.Vacation2020DTO.Agustos2020_C1,
                        Agustos2020_C2 = e.Vacation2020DTO.Agustos2020_C2,
                        Agustos2020_C3 = e.Vacation2020DTO.Agustos2020_C3,
                        Agustos2020_C4 = e.Vacation2020DTO.Agustos2020_C4,
                        Agustos2020_C5 = e.Vacation2020DTO.Agustos2020_C5,
                        Agustos2020_C6 = e.Vacation2020DTO.Agustos2020_C6,

                        Eylul2020_C1 = e.Vacation2020DTO.Eylul2020_C1,
                        Eylul2020_C2 = e.Vacation2020DTO.Eylul2020_C2,
                        Eylul2020_C3 = e.Vacation2020DTO.Eylul2020_C3,
                        Eylul2020_C4 = e.Vacation2020DTO.Eylul2020_C4,
                        Eylul2020_C5 = e.Vacation2020DTO.Eylul2020_C5,
                        Eylul2020_C6 = e.Vacation2020DTO.Eylul2020_C6,

                        Ekim2020_C1 = e.Vacation2020DTO.Ekim2020_C1,
                        Ekim2020_C2 = e.Vacation2020DTO.Ekim2020_C2,
                        Ekim2020_C3 = e.Vacation2020DTO.Ekim2020_C3,
                        Ekim2020_C4 = e.Vacation2020DTO.Ekim2020_C4,
                        Ekim2020_C5 = e.Vacation2020DTO.Ekim2020_C5,
                        Ekim2020_C6 = e.Vacation2020DTO.Ekim2020_C6,

                        Kasim2020_C1 = e.Vacation2020DTO.Kasim2020_C1,
                        Kasim2020_C2 = e.Vacation2020DTO.Kasim2020_C2,
                        Kasim2020_C3 = e.Vacation2020DTO.Kasim2020_C3,
                        Kasim2020_C4 = e.Vacation2020DTO.Kasim2020_C4,
                        Kasim2020_C5 = e.Vacation2020DTO.Kasim2020_C5,
                        Kasim2020_C6 = e.Vacation2020DTO.Kasim2020_C6,

                        Aralik2020_C1 = e.Vacation2020DTO.Aralik2020_C1,
                        Aralik2020_C2 = e.Vacation2020DTO.Aralik2020_C2,
                        Aralik2020_C3 = e.Vacation2020DTO.Aralik2020_C3,
                        Aralik2020_C4 = e.Vacation2020DTO.Aralik2020_C4,
                        Aralik2020_C5 = e.Vacation2020DTO.Aralik2020_C5,
                        Aralik2020_C6 = e.Vacation2020DTO.Aralik2020_C6,
                    },
                    Vacation2021 = new Vacation2021
                    {
                        Id = e.Id,
                        Ocak2021_C1 = e.Vacation2021DTO.Ocak2021_C1,
                        Ocak2021_C2 = e.Vacation2021DTO.Ocak2021_C2,
                        Ocak2021_C3 = e.Vacation2021DTO.Ocak2021_C3,
                        Ocak2021_C4 = e.Vacation2021DTO.Ocak2021_C4,
                        Ocak2021_C5 = e.Vacation2021DTO.Ocak2021_C5,
                        Ocak2021_C6 = e.Vacation2021DTO.Ocak2021_C6,

                        Subat2021_C1 = e.Vacation2021DTO.Subat2021_C1,
                        Subat2021_C2 = e.Vacation2021DTO.Subat2021_C2,
                        Subat2021_C3 = e.Vacation2021DTO.Subat2021_C3,
                        Subat2021_C4 = e.Vacation2021DTO.Subat2021_C4,
                        Subat2021_C5 = e.Vacation2021DTO.Subat2021_C5,
                        Subat2021_C6 = e.Vacation2021DTO.Subat2021_C6,

                        Mart2021_C1 = e.Vacation2021DTO.Mart2021_C1,
                        Mart2021_C2 = e.Vacation2021DTO.Mart2021_C2,
                        Mart2021_C3 = e.Vacation2021DTO.Mart2021_C3,
                        Mart2021_C4 = e.Vacation2021DTO.Mart2021_C4,
                        Mart2021_C5 = e.Vacation2021DTO.Mart2021_C5,
                        Mart2021_C6 = e.Vacation2021DTO.Mart2021_C6,

                        Nisan2021_C1 = e.Vacation2021DTO.Nisan2021_C1,
                        Nisan2021_C2 = e.Vacation2021DTO.Nisan2021_C2,
                        Nisan2021_C3 = e.Vacation2021DTO.Nisan2021_C3,
                        Nisan2021_C4 = e.Vacation2021DTO.Nisan2021_C4,
                        Nisan2021_C5 = e.Vacation2021DTO.Nisan2021_C5,
                        Nisan2021_C6 = e.Vacation2021DTO.Nisan2021_C6,

                        Mayis2021_C1 = e.Vacation2021DTO.Mayis2021_C1,
                        Mayis2021_C2 = e.Vacation2021DTO.Mayis2021_C2,
                        Mayis2021_C3 = e.Vacation2021DTO.Mayis2021_C3,
                        Mayis2021_C4 = e.Vacation2021DTO.Mayis2021_C4,
                        Mayis2021_C5 = e.Vacation2021DTO.Mayis2021_C5,
                        Mayis2021_C6 = e.Vacation2021DTO.Mayis2021_C6,

                        Haziran2021_C1 = e.Vacation2021DTO.Haziran2021_C1,
                        Haziran2021_C2 = e.Vacation2021DTO.Haziran2021_C2,
                        Haziran2021_C3 = e.Vacation2021DTO.Haziran2021_C3,
                        Haziran2021_C4 = e.Vacation2021DTO.Haziran2021_C4,
                        Haziran2021_C5 = e.Vacation2021DTO.Haziran2021_C5,
                        Haziran2021_C6 = e.Vacation2021DTO.Haziran2021_C6,

                        Temmuz2021_C1 = e.Vacation2021DTO.Temmuz2021_C1,
                        Temmuz2021_C2 = e.Vacation2021DTO.Temmuz2021_C2,
                        Temmuz2021_C3 = e.Vacation2021DTO.Temmuz2021_C3,
                        Temmuz2021_C4 = e.Vacation2021DTO.Temmuz2021_C4,
                        Temmuz2021_C5 = e.Vacation2021DTO.Temmuz2021_C5,
                        Temmuz2021_C6 = e.Vacation2021DTO.Temmuz2021_C6,

                        Agustos2021_C1 = e.Vacation2021DTO.Agustos2021_C1,
                        Agustos2021_C2 = e.Vacation2021DTO.Agustos2021_C2,
                        Agustos2021_C3 = e.Vacation2021DTO.Agustos2021_C3,
                        Agustos2021_C4 = e.Vacation2021DTO.Agustos2021_C4,
                        Agustos2021_C5 = e.Vacation2021DTO.Agustos2021_C5,
                        Agustos2021_C6 = e.Vacation2021DTO.Agustos2021_C6,

                        Eylul2021_C1 = e.Vacation2021DTO.Eylul2021_C1,
                        Eylul2021_C2 = e.Vacation2021DTO.Eylul2021_C2,
                        Eylul2021_C3 = e.Vacation2021DTO.Eylul2021_C3,
                        Eylul2021_C4 = e.Vacation2021DTO.Eylul2021_C4,
                        Eylul2021_C5 = e.Vacation2021DTO.Eylul2021_C5,
                        Eylul2021_C6 = e.Vacation2021DTO.Eylul2021_C6,

                        Ekim2021_C1 = e.Vacation2021DTO.Ekim2021_C1,
                        Ekim2021_C2 = e.Vacation2021DTO.Ekim2021_C2,
                        Ekim2021_C3 = e.Vacation2021DTO.Ekim2021_C3,
                        Ekim2021_C4 = e.Vacation2021DTO.Ekim2021_C4,
                        Ekim2021_C5 = e.Vacation2021DTO.Ekim2021_C5,
                        Ekim2021_C6 = e.Vacation2021DTO.Ekim2021_C6,

                        Kasim2021_C1 = e.Vacation2021DTO.Kasim2021_C1,
                        Kasim2021_C2 = e.Vacation2021DTO.Kasim2021_C2,
                        Kasim2021_C3 = e.Vacation2021DTO.Kasim2021_C3,
                        Kasim2021_C4 = e.Vacation2021DTO.Kasim2021_C4,
                        Kasim2021_C5 = e.Vacation2021DTO.Kasim2021_C5,
                        Kasim2021_C6 = e.Vacation2021DTO.Kasim2021_C6,

                        Aralik2021_C1 = e.Vacation2021DTO.Aralik2021_C1,
                        Aralik2021_C2 = e.Vacation2021DTO.Aralik2021_C2,
                        Aralik2021_C3 = e.Vacation2021DTO.Aralik2021_C3,
                        Aralik2021_C4 = e.Vacation2021DTO.Aralik2021_C4,
                        Aralik2021_C5 = e.Vacation2021DTO.Aralik2021_C5,
                        Aralik2021_C6 = e.Vacation2021DTO.Aralik2021_C6,
                    },
                    Vacation2022 = new Vacation2022
                    {
                        Id = e.Id,
                        Ocak2022_C1 = e.Vacation2022DTO.Ocak2022_C1,
                        Ocak2022_C2 = e.Vacation2022DTO.Ocak2022_C2,
                        Ocak2022_C3 = e.Vacation2022DTO.Ocak2022_C3,
                        Ocak2022_C4 = e.Vacation2022DTO.Ocak2022_C4,
                        Ocak2022_C5 = e.Vacation2022DTO.Ocak2022_C5,
                        Ocak2022_C6 = e.Vacation2022DTO.Ocak2022_C6,

                        Subat2022_C1 = e.Vacation2022DTO.Subat2022_C1,
                        Subat2022_C2 = e.Vacation2022DTO.Subat2022_C2,
                        Subat2022_C3 = e.Vacation2022DTO.Subat2022_C3,
                        Subat2022_C4 = e.Vacation2022DTO.Subat2022_C4,
                        Subat2022_C5 = e.Vacation2022DTO.Subat2022_C5,
                        Subat2022_C6 = e.Vacation2022DTO.Subat2022_C6,

                        Mart2022_C1 = e.Vacation2022DTO.Mart2022_C1,
                        Mart2022_C2 = e.Vacation2022DTO.Mart2022_C2,
                        Mart2022_C3 = e.Vacation2022DTO.Mart2022_C3,
                        Mart2022_C4 = e.Vacation2022DTO.Mart2022_C4,
                        Mart2022_C5 = e.Vacation2022DTO.Mart2022_C5,
                        Mart2022_C6 = e.Vacation2022DTO.Mart2022_C6,

                        Nisan2022_C1 = e.Vacation2022DTO.Nisan2022_C1,
                        Nisan2022_C2 = e.Vacation2022DTO.Nisan2022_C2,
                        Nisan2022_C3 = e.Vacation2022DTO.Nisan2022_C3,
                        Nisan2022_C4 = e.Vacation2022DTO.Nisan2022_C4,
                        Nisan2022_C5 = e.Vacation2022DTO.Nisan2022_C5,
                        Nisan2022_C6 = e.Vacation2022DTO.Nisan2022_C6,

                        Mayis2022_C1 = e.Vacation2022DTO.Mayis2022_C1,
                        Mayis2022_C2 = e.Vacation2022DTO.Mayis2022_C2,
                        Mayis2022_C3 = e.Vacation2022DTO.Mayis2022_C3,
                        Mayis2022_C4 = e.Vacation2022DTO.Mayis2022_C4,
                        Mayis2022_C5 = e.Vacation2022DTO.Mayis2022_C5,
                        Mayis2022_C6 = e.Vacation2022DTO.Mayis2022_C6,

                        Haziran2022_C1 = e.Vacation2022DTO.Haziran2022_C1,
                        Haziran2022_C2 = e.Vacation2022DTO.Haziran2022_C2,
                        Haziran2022_C3 = e.Vacation2022DTO.Haziran2022_C3,
                        Haziran2022_C4 = e.Vacation2022DTO.Haziran2022_C4,
                        Haziran2022_C5 = e.Vacation2022DTO.Haziran2022_C5,
                        Haziran2022_C6 = e.Vacation2022DTO.Haziran2022_C6,

                        Temmuz2022_C1 = e.Vacation2022DTO.Temmuz2022_C1,
                        Temmuz2022_C2 = e.Vacation2022DTO.Temmuz2022_C2,
                        Temmuz2022_C3 = e.Vacation2022DTO.Temmuz2022_C3,
                        Temmuz2022_C4 = e.Vacation2022DTO.Temmuz2022_C4,
                        Temmuz2022_C5 = e.Vacation2022DTO.Temmuz2022_C5,
                        Temmuz2022_C6 = e.Vacation2022DTO.Temmuz2022_C6,

                        Agustos2022_C1 = e.Vacation2022DTO.Agustos2022_C1,
                        Agustos2022_C2 = e.Vacation2022DTO.Agustos2022_C2,
                        Agustos2022_C3 = e.Vacation2022DTO.Agustos2022_C3,
                        Agustos2022_C4 = e.Vacation2022DTO.Agustos2022_C4,
                        Agustos2022_C5 = e.Vacation2022DTO.Agustos2022_C5,
                        Agustos2022_C6 = e.Vacation2022DTO.Agustos2022_C6,

                        Eylul2022_C1 = e.Vacation2022DTO.Eylul2022_C1,
                        Eylul2022_C2 = e.Vacation2022DTO.Eylul2022_C2,
                        Eylul2022_C3 = e.Vacation2022DTO.Eylul2022_C3,
                        Eylul2022_C4 = e.Vacation2022DTO.Eylul2022_C4,
                        Eylul2022_C5 = e.Vacation2022DTO.Eylul2022_C5,
                        Eylul2022_C6 = e.Vacation2022DTO.Eylul2022_C6,

                        Ekim2022_C1 = e.Vacation2022DTO.Ekim2022_C1,
                        Ekim2022_C2 = e.Vacation2022DTO.Ekim2022_C2,
                        Ekim2022_C3 = e.Vacation2022DTO.Ekim2022_C3,
                        Ekim2022_C4 = e.Vacation2022DTO.Ekim2022_C4,
                        Ekim2022_C5 = e.Vacation2022DTO.Ekim2022_C5,
                        Ekim2022_C6 = e.Vacation2022DTO.Ekim2022_C6,

                        Kasim2022_C1 = e.Vacation2022DTO.Kasim2022_C1,
                        Kasim2022_C2 = e.Vacation2022DTO.Kasim2022_C2,
                        Kasim2022_C3 = e.Vacation2022DTO.Kasim2022_C3,
                        Kasim2022_C4 = e.Vacation2022DTO.Kasim2022_C4,
                        Kasim2022_C5 = e.Vacation2022DTO.Kasim2022_C5,
                        Kasim2022_C6 = e.Vacation2022DTO.Kasim2022_C6,

                        Aralik2022_C1 = e.Vacation2022DTO.Aralik2022_C1,
                        Aralik2022_C2 = e.Vacation2022DTO.Aralik2022_C2,
                        Aralik2022_C3 = e.Vacation2022DTO.Aralik2022_C3,
                        Aralik2022_C4 = e.Vacation2022DTO.Aralik2022_C4,
                        Aralik2022_C5 = e.Vacation2022DTO.Aralik2022_C5,
                        Aralik2022_C6 = e.Vacation2022DTO.Aralik2022_C6,
                    },
                    Vacation2023 = new Vacation2023
                    {
                        Id = e.Id,
                        Ocak2023_C1 = e.Vacation2023DTO.Ocak2023_C1,
                        Ocak2023_C2 = e.Vacation2023DTO.Ocak2023_C2,
                        Ocak2023_C3 = e.Vacation2023DTO.Ocak2023_C3,
                        Ocak2023_C4 = e.Vacation2023DTO.Ocak2023_C4,
                        Ocak2023_C5 = e.Vacation2023DTO.Ocak2023_C5,
                        Ocak2023_C6 = e.Vacation2023DTO.Ocak2023_C6,

                        Subat2023_C1 = e.Vacation2023DTO.Subat2023_C1,
                        Subat2023_C2 = e.Vacation2023DTO.Subat2023_C2,
                        Subat2023_C3 = e.Vacation2023DTO.Subat2023_C3,
                        Subat2023_C4 = e.Vacation2023DTO.Subat2023_C4,
                        Subat2023_C5 = e.Vacation2023DTO.Subat2023_C5,
                        Subat2023_C6 = e.Vacation2023DTO.Subat2023_C6,

                        Mart2023_C1 = e.Vacation2023DTO.Mart2023_C1,
                        Mart2023_C2 = e.Vacation2023DTO.Mart2023_C2,
                        Mart2023_C3 = e.Vacation2023DTO.Mart2023_C3,
                        Mart2023_C4 = e.Vacation2023DTO.Mart2023_C4,
                        Mart2023_C5 = e.Vacation2023DTO.Mart2023_C5,
                        Mart2023_C6 = e.Vacation2023DTO.Mart2023_C6,

                        Nisan2023_C1 = e.Vacation2023DTO.Nisan2023_C1,
                        Nisan2023_C2 = e.Vacation2023DTO.Nisan2023_C2,
                        Nisan2023_C3 = e.Vacation2023DTO.Nisan2023_C3,
                        Nisan2023_C4 = e.Vacation2023DTO.Nisan2023_C4,
                        Nisan2023_C5 = e.Vacation2023DTO.Nisan2023_C5,
                        Nisan2023_C6 = e.Vacation2023DTO.Nisan2023_C6,

                        Mayis2023_C1 = e.Vacation2023DTO.Mayis2023_C1,
                        Mayis2023_C2 = e.Vacation2023DTO.Mayis2023_C2,
                        Mayis2023_C3 = e.Vacation2023DTO.Mayis2023_C3,
                        Mayis2023_C4 = e.Vacation2023DTO.Mayis2023_C4,
                        Mayis2023_C5 = e.Vacation2023DTO.Mayis2023_C5,
                        Mayis2023_C6 = e.Vacation2023DTO.Mayis2023_C6,

                        Haziran2023_C1 = e.Vacation2023DTO.Haziran2023_C1,
                        Haziran2023_C2 = e.Vacation2023DTO.Haziran2023_C2,
                        Haziran2023_C3 = e.Vacation2023DTO.Haziran2023_C3,
                        Haziran2023_C4 = e.Vacation2023DTO.Haziran2023_C4,
                        Haziran2023_C5 = e.Vacation2023DTO.Haziran2023_C5,
                        Haziran2023_C6 = e.Vacation2023DTO.Haziran2023_C6,

                        Temmuz2023_C1 = e.Vacation2023DTO.Temmuz2023_C1,
                        Temmuz2023_C2 = e.Vacation2023DTO.Temmuz2023_C2,
                        Temmuz2023_C3 = e.Vacation2023DTO.Temmuz2023_C3,
                        Temmuz2023_C4 = e.Vacation2023DTO.Temmuz2023_C4,
                        Temmuz2023_C5 = e.Vacation2023DTO.Temmuz2023_C5,
                        Temmuz2023_C6 = e.Vacation2023DTO.Temmuz2023_C6,

                        Agustos2023_C1 = e.Vacation2023DTO.Agustos2023_C1,
                        Agustos2023_C2 = e.Vacation2023DTO.Agustos2023_C2,
                        Agustos2023_C3 = e.Vacation2023DTO.Agustos2023_C3,
                        Agustos2023_C4 = e.Vacation2023DTO.Agustos2023_C4,
                        Agustos2023_C5 = e.Vacation2023DTO.Agustos2023_C5,
                        Agustos2023_C6 = e.Vacation2023DTO.Agustos2023_C6,

                        Eylul2023_C1 = e.Vacation2023DTO.Eylul2023_C1,
                        Eylul2023_C2 = e.Vacation2023DTO.Eylul2023_C2,
                        Eylul2023_C3 = e.Vacation2023DTO.Eylul2023_C3,
                        Eylul2023_C4 = e.Vacation2023DTO.Eylul2023_C4,
                        Eylul2023_C5 = e.Vacation2023DTO.Eylul2023_C5,
                        Eylul2023_C6 = e.Vacation2023DTO.Eylul2023_C6,

                        Ekim2023_C1 = e.Vacation2023DTO.Ekim2023_C1,
                        Ekim2023_C2 = e.Vacation2023DTO.Ekim2023_C2,
                        Ekim2023_C3 = e.Vacation2023DTO.Ekim2023_C3,
                        Ekim2023_C4 = e.Vacation2023DTO.Ekim2023_C4,
                        Ekim2023_C5 = e.Vacation2023DTO.Ekim2023_C5,
                        Ekim2023_C6 = e.Vacation2023DTO.Ekim2023_C6,

                        Kasim2023_C1 = e.Vacation2023DTO.Kasim2023_C1,
                        Kasim2023_C2 = e.Vacation2023DTO.Kasim2023_C2,
                        Kasim2023_C3 = e.Vacation2023DTO.Kasim2023_C3,
                        Kasim2023_C4 = e.Vacation2023DTO.Kasim2023_C4,
                        Kasim2023_C5 = e.Vacation2023DTO.Kasim2023_C5,
                        Kasim2023_C6 = e.Vacation2023DTO.Kasim2023_C6,

                        Aralik2023_C1 = e.Vacation2023DTO.Aralik2023_C1,
                        Aralik2023_C2 = e.Vacation2023DTO.Aralik2023_C2,
                        Aralik2023_C3 = e.Vacation2023DTO.Aralik2023_C3,
                        Aralik2023_C4 = e.Vacation2023DTO.Aralik2023_C4,
                        Aralik2023_C5 = e.Vacation2023DTO.Aralik2023_C5,
                        Aralik2023_C6 = e.Vacation2023DTO.Aralik2023_C6,
                    }


                });
            }
        }

    }
}
