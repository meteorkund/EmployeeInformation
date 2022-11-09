using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.Commands;

public class UpdateEmployeeCommand : IUpdateEmployeeCommand
{
    readonly EmployeesDbContextFactory _contextFactory;

    public UpdateEmployeeCommand(EmployeesDbContextFactory contextFactory)
    {
        _contextFactory = contextFactory;
    }
    public async Task Execute(Employee employee)
    {
        using (EmployeesDbContext context = _contextFactory.Create())
        {

            var person = await context.Employees.FirstOrDefaultAsync(e => e.Id == employee.Id);
            var vacation2018 = await context.Vacations2018.FirstOrDefaultAsync(v => v.Id == employee.Id);
            var vacation2019 = await context.Vacations2019.FirstOrDefaultAsync(v => v.Id == employee.Id);
            var vacation2020 = await context.Vacations2020.FirstOrDefaultAsync(v => v.Id == employee.Id);
            var vacation2021 = await context.Vacations2021.FirstOrDefaultAsync(v => v.Id == employee.Id);
            var vacation2022 = await context.Vacations2022.FirstOrDefaultAsync(v => v.Id == employee.Id);
            var vacation2023 = await context.Vacations2023.FirstOrDefaultAsync(v => v.Id == employee.Id);


            person.Fotograf = employee.Fotograf;
            person.Isim = employee.Isim;
            person.Soyisim = employee.Soyisim;
            person.Durum = employee.Durum;
            person.TCKimlik = employee.TCKimlik;
            person.DogumTarihi = employee.DogumTarihi;
            person.MedeniDurum = employee.MedeniDurum;
            person.EgitimDurumu = employee.EgitimDurumu;
            person.Askerlik = employee.Askerlik;

            person.DepartmentDTOId = employee.Departman.Id;
            person.SectorDTOId = employee.Sector.Id;
            person.EducationDTOId = employee.Education.Id;
            person.MilitaryServiceDTOId = employee.Military.Id;
            person.MaritialDTOId = employee.Maritial.Id;

            person.Gorev = employee.Gorev;
            person.IseGiris = employee.IseGiris;
            person.IstenCikis = employee.IstenCikis;
            person.Maas = employee.Maas;
            person.CepTel = employee.CepTel;
            person.CalismaSuresi = employee.CalismaSuresi;
            person.BaslamaTarihi = employee.BaslamaTarihi;
            person.Adres = employee.Adres;
            person.EkBilgi = employee.EkBilgi;

            #region VACATION 2018
            vacation2018.Ocak2018_C1 = employee.Vacation2018.Ocak2018_C1;
            vacation2018.Ocak2018_C2 = employee.Vacation2018.Ocak2018_C2;
            vacation2018.Ocak2018_C3 = employee.Vacation2018.Ocak2018_C3;
            vacation2018.Ocak2018_C4 = employee.Vacation2018.Ocak2018_C4;
            vacation2018.Ocak2018_C5 = employee.Vacation2018.Ocak2018_C5;
            vacation2018.Ocak2018_C6 = employee.Vacation2018.Ocak2018_C6;

            vacation2018.Subat2018_C1 = employee.Vacation2018.Subat2018_C1;
            vacation2018.Subat2018_C2 = employee.Vacation2018.Subat2018_C2;
            vacation2018.Subat2018_C3 = employee.Vacation2018.Subat2018_C3;
            vacation2018.Subat2018_C4 = employee.Vacation2018.Subat2018_C4;
            vacation2018.Subat2018_C5 = employee.Vacation2018.Subat2018_C5;
            vacation2018.Subat2018_C6 = employee.Vacation2018.Subat2018_C6;

            vacation2018.Mart2018_C1 = employee.Vacation2018.Mart2018_C1;
            vacation2018.Mart2018_C2 = employee.Vacation2018.Mart2018_C2;
            vacation2018.Mart2018_C3 = employee.Vacation2018.Mart2018_C3;
            vacation2018.Mart2018_C4 = employee.Vacation2018.Mart2018_C4;
            vacation2018.Mart2018_C5 = employee.Vacation2018.Mart2018_C5;
            vacation2018.Mart2018_C6 = employee.Vacation2018.Mart2018_C6;

            vacation2018.Nisan2018_C1 = employee.Vacation2018.Nisan2018_C1;
            vacation2018.Nisan2018_C2 = employee.Vacation2018.Nisan2018_C2;
            vacation2018.Nisan2018_C3 = employee.Vacation2018.Nisan2018_C3;
            vacation2018.Nisan2018_C4 = employee.Vacation2018.Nisan2018_C4;
            vacation2018.Nisan2018_C5 = employee.Vacation2018.Nisan2018_C5;
            vacation2018.Nisan2018_C6 = employee.Vacation2018.Nisan2018_C6;

            vacation2018.Mayis2018_C1 = employee.Vacation2018.Mayis2018_C1;
            vacation2018.Mayis2018_C2 = employee.Vacation2018.Mayis2018_C2;
            vacation2018.Mayis2018_C3 = employee.Vacation2018.Mayis2018_C3;
            vacation2018.Mayis2018_C4 = employee.Vacation2018.Mayis2018_C4;
            vacation2018.Mayis2018_C5 = employee.Vacation2018.Mayis2018_C5;
            vacation2018.Mayis2018_C6 = employee.Vacation2018.Mayis2018_C6;

            vacation2018.Haziran2018_C1 = employee.Vacation2018.Haziran2018_C1;
            vacation2018.Haziran2018_C2 = employee.Vacation2018.Haziran2018_C2;
            vacation2018.Haziran2018_C3 = employee.Vacation2018.Haziran2018_C3;
            vacation2018.Haziran2018_C4 = employee.Vacation2018.Haziran2018_C4;
            vacation2018.Haziran2018_C5 = employee.Vacation2018.Haziran2018_C5;
            vacation2018.Haziran2018_C6 = employee.Vacation2018.Haziran2018_C6;

            vacation2018.Temmuz2018_C1 = employee.Vacation2018.Temmuz2018_C1;
            vacation2018.Temmuz2018_C2 = employee.Vacation2018.Temmuz2018_C2;
            vacation2018.Temmuz2018_C3 = employee.Vacation2018.Temmuz2018_C3;
            vacation2018.Temmuz2018_C4 = employee.Vacation2018.Temmuz2018_C4;
            vacation2018.Temmuz2018_C5 = employee.Vacation2018.Temmuz2018_C5;
            vacation2018.Temmuz2018_C6 = employee.Vacation2018.Temmuz2018_C6;

            vacation2018.Agustos2018_C1 = employee.Vacation2018.Agustos2018_C1;
            vacation2018.Agustos2018_C2 = employee.Vacation2018.Agustos2018_C2;
            vacation2018.Agustos2018_C3 = employee.Vacation2018.Agustos2018_C3;
            vacation2018.Agustos2018_C4 = employee.Vacation2018.Agustos2018_C4;
            vacation2018.Agustos2018_C5 = employee.Vacation2018.Agustos2018_C5;
            vacation2018.Agustos2018_C6 = employee.Vacation2018.Agustos2018_C6;

            vacation2018.Eylul2018_C1 = employee.Vacation2018.Eylul2018_C1;
            vacation2018.Eylul2018_C2 = employee.Vacation2018.Eylul2018_C2;
            vacation2018.Eylul2018_C3 = employee.Vacation2018.Eylul2018_C3;
            vacation2018.Eylul2018_C4 = employee.Vacation2018.Eylul2018_C4;
            vacation2018.Eylul2018_C5 = employee.Vacation2018.Eylul2018_C5;
            vacation2018.Eylul2018_C6 = employee.Vacation2018.Eylul2018_C6;

            vacation2018.Ekim2018_C1 = employee.Vacation2018.Ekim2018_C1;
            vacation2018.Ekim2018_C2 = employee.Vacation2018.Ekim2018_C2;
            vacation2018.Ekim2018_C3 = employee.Vacation2018.Ekim2018_C3;
            vacation2018.Ekim2018_C4 = employee.Vacation2018.Ekim2018_C4;
            vacation2018.Ekim2018_C5 = employee.Vacation2018.Ekim2018_C5;
            vacation2018.Ekim2018_C6 = employee.Vacation2018.Ekim2018_C6;

            vacation2018.Kasim2018_C1 = employee.Vacation2018.Kasim2018_C1;
            vacation2018.Kasim2018_C2 = employee.Vacation2018.Kasim2018_C2;
            vacation2018.Kasim2018_C3 = employee.Vacation2018.Kasim2018_C3;
            vacation2018.Kasim2018_C4 = employee.Vacation2018.Kasim2018_C4;
            vacation2018.Kasim2018_C5 = employee.Vacation2018.Kasim2018_C5;
            vacation2018.Kasim2018_C6 = employee.Vacation2018.Kasim2018_C6;

            vacation2018.Aralik2018_C1 = employee.Vacation2018.Aralik2018_C1;
            vacation2018.Aralik2018_C2 = employee.Vacation2018.Aralik2018_C2;
            vacation2018.Aralik2018_C3 = employee.Vacation2018.Aralik2018_C3;
            vacation2018.Aralik2018_C4 = employee.Vacation2018.Aralik2018_C4;
            vacation2018.Aralik2018_C5 = employee.Vacation2018.Aralik2018_C5;
            vacation2018.Aralik2018_C6 = employee.Vacation2018.Aralik2018_C6;
            #endregion

            #region VACATION 2019
            vacation2019.Ocak2019_C1 = employee.Vacation2019.Ocak2019_C1;
            vacation2019.Ocak2019_C2 = employee.Vacation2019.Ocak2019_C2;
            vacation2019.Ocak2019_C3 = employee.Vacation2019.Ocak2019_C3;
            vacation2019.Ocak2019_C4 = employee.Vacation2019.Ocak2019_C4;
            vacation2019.Ocak2019_C5 = employee.Vacation2019.Ocak2019_C5;
            vacation2019.Ocak2019_C6 = employee.Vacation2019.Ocak2019_C6;

            vacation2019.Subat2019_C1 = employee.Vacation2019.Subat2019_C1;
            vacation2019.Subat2019_C2 = employee.Vacation2019.Subat2019_C2;
            vacation2019.Subat2019_C3 = employee.Vacation2019.Subat2019_C3;
            vacation2019.Subat2019_C4 = employee.Vacation2019.Subat2019_C4;
            vacation2019.Subat2019_C5 = employee.Vacation2019.Subat2019_C5;
            vacation2019.Subat2019_C6 = employee.Vacation2019.Subat2019_C6;

            vacation2019.Mart2019_C1 = employee.Vacation2019.Mart2019_C1;
            vacation2019.Mart2019_C2 = employee.Vacation2019.Mart2019_C2;
            vacation2019.Mart2019_C3 = employee.Vacation2019.Mart2019_C3;
            vacation2019.Mart2019_C4 = employee.Vacation2019.Mart2019_C4;
            vacation2019.Mart2019_C5 = employee.Vacation2019.Mart2019_C5;
            vacation2019.Mart2019_C6 = employee.Vacation2019.Mart2019_C6;

            vacation2019.Nisan2019_C1 = employee.Vacation2019.Nisan2019_C1;
            vacation2019.Nisan2019_C2 = employee.Vacation2019.Nisan2019_C2;
            vacation2019.Nisan2019_C3 = employee.Vacation2019.Nisan2019_C3;
            vacation2019.Nisan2019_C4 = employee.Vacation2019.Nisan2019_C4;
            vacation2019.Nisan2019_C5 = employee.Vacation2019.Nisan2019_C5;
            vacation2019.Nisan2019_C6 = employee.Vacation2019.Nisan2019_C6;

            vacation2019.Mayis2019_C1 = employee.Vacation2019.Mayis2019_C1;
            vacation2019.Mayis2019_C2 = employee.Vacation2019.Mayis2019_C2;
            vacation2019.Mayis2019_C3 = employee.Vacation2019.Mayis2019_C3;
            vacation2019.Mayis2019_C4 = employee.Vacation2019.Mayis2019_C4;
            vacation2019.Mayis2019_C5 = employee.Vacation2019.Mayis2019_C5;
            vacation2019.Mayis2019_C6 = employee.Vacation2019.Mayis2019_C6;

            vacation2019.Haziran2019_C1 = employee.Vacation2019.Haziran2019_C1;
            vacation2019.Haziran2019_C2 = employee.Vacation2019.Haziran2019_C2;
            vacation2019.Haziran2019_C3 = employee.Vacation2019.Haziran2019_C3;
            vacation2019.Haziran2019_C4 = employee.Vacation2019.Haziran2019_C4;
            vacation2019.Haziran2019_C5 = employee.Vacation2019.Haziran2019_C5;
            vacation2019.Haziran2019_C6 = employee.Vacation2019.Haziran2019_C6;

            vacation2019.Temmuz2019_C1 = employee.Vacation2019.Temmuz2019_C1;
            vacation2019.Temmuz2019_C2 = employee.Vacation2019.Temmuz2019_C2;
            vacation2019.Temmuz2019_C3 = employee.Vacation2019.Temmuz2019_C3;
            vacation2019.Temmuz2019_C4 = employee.Vacation2019.Temmuz2019_C4;
            vacation2019.Temmuz2019_C5 = employee.Vacation2019.Temmuz2019_C5;
            vacation2019.Temmuz2019_C6 = employee.Vacation2019.Temmuz2019_C6;

            vacation2019.Agustos2019_C1 = employee.Vacation2019.Agustos2019_C1;
            vacation2019.Agustos2019_C2 = employee.Vacation2019.Agustos2019_C2;
            vacation2019.Agustos2019_C3 = employee.Vacation2019.Agustos2019_C3;
            vacation2019.Agustos2019_C4 = employee.Vacation2019.Agustos2019_C4;
            vacation2019.Agustos2019_C5 = employee.Vacation2019.Agustos2019_C5;
            vacation2019.Agustos2019_C6 = employee.Vacation2019.Agustos2019_C6;

            vacation2019.Eylul2019_C1 = employee.Vacation2019.Eylul2019_C1;
            vacation2019.Eylul2019_C2 = employee.Vacation2019.Eylul2019_C2;
            vacation2019.Eylul2019_C3 = employee.Vacation2019.Eylul2019_C3;
            vacation2019.Eylul2019_C4 = employee.Vacation2019.Eylul2019_C4;
            vacation2019.Eylul2019_C5 = employee.Vacation2019.Eylul2019_C5;
            vacation2019.Eylul2019_C6 = employee.Vacation2019.Eylul2019_C6;

            vacation2019.Ekim2019_C1 = employee.Vacation2019.Ekim2019_C1;
            vacation2019.Ekim2019_C2 = employee.Vacation2019.Ekim2019_C2;
            vacation2019.Ekim2019_C3 = employee.Vacation2019.Ekim2019_C3;
            vacation2019.Ekim2019_C4 = employee.Vacation2019.Ekim2019_C4;
            vacation2019.Ekim2019_C5 = employee.Vacation2019.Ekim2019_C5;
            vacation2019.Ekim2019_C6 = employee.Vacation2019.Ekim2019_C6;

            vacation2019.Kasim2019_C1 = employee.Vacation2019.Kasim2019_C1;
            vacation2019.Kasim2019_C2 = employee.Vacation2019.Kasim2019_C2;
            vacation2019.Kasim2019_C3 = employee.Vacation2019.Kasim2019_C3;
            vacation2019.Kasim2019_C4 = employee.Vacation2019.Kasim2019_C4;
            vacation2019.Kasim2019_C5 = employee.Vacation2019.Kasim2019_C5;
            vacation2019.Kasim2019_C6 = employee.Vacation2019.Kasim2019_C6;

            vacation2019.Aralik2019_C1 = employee.Vacation2019.Aralik2019_C1;
            vacation2019.Aralik2019_C2 = employee.Vacation2019.Aralik2019_C2;
            vacation2019.Aralik2019_C3 = employee.Vacation2019.Aralik2019_C3;
            vacation2019.Aralik2019_C4 = employee.Vacation2019.Aralik2019_C4;
            vacation2019.Aralik2019_C5 = employee.Vacation2019.Aralik2019_C5;
            vacation2019.Aralik2019_C6 = employee.Vacation2019.Aralik2019_C6;
            #endregion

            #region VACATION 2020

            vacation2020.Ocak2020_C1 = employee.Vacation2020.Ocak2020_C1;
            vacation2020.Ocak2020_C2 = employee.Vacation2020.Ocak2020_C2;
            vacation2020.Ocak2020_C3 = employee.Vacation2020.Ocak2020_C3;
            vacation2020.Ocak2020_C4 = employee.Vacation2020.Ocak2020_C4;
            vacation2020.Ocak2020_C5 = employee.Vacation2020.Ocak2020_C5;
            vacation2020.Ocak2020_C6 = employee.Vacation2020.Ocak2020_C6;

            vacation2020.Subat2020_C1 = employee.Vacation2020.Subat2020_C1;
            vacation2020.Subat2020_C2 = employee.Vacation2020.Subat2020_C2;
            vacation2020.Subat2020_C3 = employee.Vacation2020.Subat2020_C3;
            vacation2020.Subat2020_C4 = employee.Vacation2020.Subat2020_C4;
            vacation2020.Subat2020_C5 = employee.Vacation2020.Subat2020_C5;
            vacation2020.Subat2020_C6 = employee.Vacation2020.Subat2020_C6;

            vacation2020.Mart2020_C1 = employee.Vacation2020.Mart2020_C1;
            vacation2020.Mart2020_C2 = employee.Vacation2020.Mart2020_C2;
            vacation2020.Mart2020_C3 = employee.Vacation2020.Mart2020_C3;
            vacation2020.Mart2020_C4 = employee.Vacation2020.Mart2020_C4;
            vacation2020.Mart2020_C5 = employee.Vacation2020.Mart2020_C5;
            vacation2020.Mart2020_C6 = employee.Vacation2020.Mart2020_C6;

            vacation2020.Nisan2020_C1 = employee.Vacation2020.Nisan2020_C1;
            vacation2020.Nisan2020_C2 = employee.Vacation2020.Nisan2020_C2;
            vacation2020.Nisan2020_C3 = employee.Vacation2020.Nisan2020_C3;
            vacation2020.Nisan2020_C4 = employee.Vacation2020.Nisan2020_C4;
            vacation2020.Nisan2020_C5 = employee.Vacation2020.Nisan2020_C5;
            vacation2020.Nisan2020_C6 = employee.Vacation2020.Nisan2020_C6;

            vacation2020.Mayis2020_C1 = employee.Vacation2020.Mayis2020_C1;
            vacation2020.Mayis2020_C2 = employee.Vacation2020.Mayis2020_C2;
            vacation2020.Mayis2020_C3 = employee.Vacation2020.Mayis2020_C3;
            vacation2020.Mayis2020_C4 = employee.Vacation2020.Mayis2020_C4;
            vacation2020.Mayis2020_C5 = employee.Vacation2020.Mayis2020_C5;
            vacation2020.Mayis2020_C6 = employee.Vacation2020.Mayis2020_C6;

            vacation2020.Haziran2020_C1 = employee.Vacation2020.Haziran2020_C1;
            vacation2020.Haziran2020_C2 = employee.Vacation2020.Haziran2020_C2;
            vacation2020.Haziran2020_C3 = employee.Vacation2020.Haziran2020_C3;
            vacation2020.Haziran2020_C4 = employee.Vacation2020.Haziran2020_C4;
            vacation2020.Haziran2020_C5 = employee.Vacation2020.Haziran2020_C5;
            vacation2020.Haziran2020_C6 = employee.Vacation2020.Haziran2020_C6;

            vacation2020.Temmuz2020_C1 = employee.Vacation2020.Temmuz2020_C1;
            vacation2020.Temmuz2020_C2 = employee.Vacation2020.Temmuz2020_C2;
            vacation2020.Temmuz2020_C3 = employee.Vacation2020.Temmuz2020_C3;
            vacation2020.Temmuz2020_C4 = employee.Vacation2020.Temmuz2020_C4;
            vacation2020.Temmuz2020_C5 = employee.Vacation2020.Temmuz2020_C5;
            vacation2020.Temmuz2020_C6 = employee.Vacation2020.Temmuz2020_C6;

            vacation2020.Agustos2020_C1 = employee.Vacation2020.Agustos2020_C1;
            vacation2020.Agustos2020_C2 = employee.Vacation2020.Agustos2020_C2;
            vacation2020.Agustos2020_C3 = employee.Vacation2020.Agustos2020_C3;
            vacation2020.Agustos2020_C4 = employee.Vacation2020.Agustos2020_C4;
            vacation2020.Agustos2020_C5 = employee.Vacation2020.Agustos2020_C5;
            vacation2020.Agustos2020_C6 = employee.Vacation2020.Agustos2020_C6;

            vacation2020.Eylul2020_C1 = employee.Vacation2020.Eylul2020_C1;
            vacation2020.Eylul2020_C2 = employee.Vacation2020.Eylul2020_C2;
            vacation2020.Eylul2020_C3 = employee.Vacation2020.Eylul2020_C3;
            vacation2020.Eylul2020_C4 = employee.Vacation2020.Eylul2020_C4;
            vacation2020.Eylul2020_C5 = employee.Vacation2020.Eylul2020_C5;
            vacation2020.Eylul2020_C6 = employee.Vacation2020.Eylul2020_C6;

            vacation2020.Ekim2020_C1 = employee.Vacation2020.Ekim2020_C1;
            vacation2020.Ekim2020_C2 = employee.Vacation2020.Ekim2020_C2;
            vacation2020.Ekim2020_C3 = employee.Vacation2020.Ekim2020_C3;
            vacation2020.Ekim2020_C4 = employee.Vacation2020.Ekim2020_C4;
            vacation2020.Ekim2020_C5 = employee.Vacation2020.Ekim2020_C5;
            vacation2020.Ekim2020_C6 = employee.Vacation2020.Ekim2020_C6;

            vacation2020.Kasim2020_C1 = employee.Vacation2020.Kasim2020_C1;
            vacation2020.Kasim2020_C2 = employee.Vacation2020.Kasim2020_C2;
            vacation2020.Kasim2020_C3 = employee.Vacation2020.Kasim2020_C3;
            vacation2020.Kasim2020_C4 = employee.Vacation2020.Kasim2020_C4;
            vacation2020.Kasim2020_C5 = employee.Vacation2020.Kasim2020_C5;
            vacation2020.Kasim2020_C6 = employee.Vacation2020.Kasim2020_C6;

            vacation2020.Aralik2020_C1 = employee.Vacation2020.Aralik2020_C1;
            vacation2020.Aralik2020_C2 = employee.Vacation2020.Aralik2020_C2;
            vacation2020.Aralik2020_C3 = employee.Vacation2020.Aralik2020_C3;
            vacation2020.Aralik2020_C4 = employee.Vacation2020.Aralik2020_C4;
            vacation2020.Aralik2020_C5 = employee.Vacation2020.Aralik2020_C5;
            vacation2020.Aralik2020_C6 = employee.Vacation2020.Aralik2020_C6;
            #endregion

            #region VACATION 2021

            vacation2021.Ocak2021_C1 = employee.Vacation2021.Ocak2021_C1;
            vacation2021.Ocak2021_C2 = employee.Vacation2021.Ocak2021_C2;
            vacation2021.Ocak2021_C3 = employee.Vacation2021.Ocak2021_C3;
            vacation2021.Ocak2021_C4 = employee.Vacation2021.Ocak2021_C4;
            vacation2021.Ocak2021_C5 = employee.Vacation2021.Ocak2021_C5;
            vacation2021.Ocak2021_C6 = employee.Vacation2021.Ocak2021_C6;

            vacation2021.Subat2021_C1 = employee.Vacation2021.Subat2021_C1;
            vacation2021.Subat2021_C2 = employee.Vacation2021.Subat2021_C2;
            vacation2021.Subat2021_C3 = employee.Vacation2021.Subat2021_C3;
            vacation2021.Subat2021_C4 = employee.Vacation2021.Subat2021_C4;
            vacation2021.Subat2021_C5 = employee.Vacation2021.Subat2021_C5;
            vacation2021.Subat2021_C6 = employee.Vacation2021.Subat2021_C6;

            vacation2021.Mart2021_C1 = employee.Vacation2021.Mart2021_C1;
            vacation2021.Mart2021_C2 = employee.Vacation2021.Mart2021_C2;
            vacation2021.Mart2021_C3 = employee.Vacation2021.Mart2021_C3;
            vacation2021.Mart2021_C4 = employee.Vacation2021.Mart2021_C4;
            vacation2021.Mart2021_C5 = employee.Vacation2021.Mart2021_C5;
            vacation2021.Mart2021_C6 = employee.Vacation2021.Mart2021_C6;

            vacation2021.Nisan2021_C1 = employee.Vacation2021.Nisan2021_C1;
            vacation2021.Nisan2021_C2 = employee.Vacation2021.Nisan2021_C2;
            vacation2021.Nisan2021_C3 = employee.Vacation2021.Nisan2021_C3;
            vacation2021.Nisan2021_C4 = employee.Vacation2021.Nisan2021_C4;
            vacation2021.Nisan2021_C5 = employee.Vacation2021.Nisan2021_C5;
            vacation2021.Nisan2021_C6 = employee.Vacation2021.Nisan2021_C6;

            vacation2021.Mayis2021_C1 = employee.Vacation2021.Mayis2021_C1;
            vacation2021.Mayis2021_C2 = employee.Vacation2021.Mayis2021_C2;
            vacation2021.Mayis2021_C3 = employee.Vacation2021.Mayis2021_C3;
            vacation2021.Mayis2021_C4 = employee.Vacation2021.Mayis2021_C4;
            vacation2021.Mayis2021_C5 = employee.Vacation2021.Mayis2021_C5;
            vacation2021.Mayis2021_C6 = employee.Vacation2021.Mayis2021_C6;

            vacation2021.Haziran2021_C1 = employee.Vacation2021.Haziran2021_C1;
            vacation2021.Haziran2021_C2 = employee.Vacation2021.Haziran2021_C2;
            vacation2021.Haziran2021_C3 = employee.Vacation2021.Haziran2021_C3;
            vacation2021.Haziran2021_C4 = employee.Vacation2021.Haziran2021_C4;
            vacation2021.Haziran2021_C5 = employee.Vacation2021.Haziran2021_C5;
            vacation2021.Haziran2021_C6 = employee.Vacation2021.Haziran2021_C6;

            vacation2021.Temmuz2021_C1 = employee.Vacation2021.Temmuz2021_C1;
            vacation2021.Temmuz2021_C2 = employee.Vacation2021.Temmuz2021_C2;
            vacation2021.Temmuz2021_C3 = employee.Vacation2021.Temmuz2021_C3;
            vacation2021.Temmuz2021_C4 = employee.Vacation2021.Temmuz2021_C4;
            vacation2021.Temmuz2021_C5 = employee.Vacation2021.Temmuz2021_C5;
            vacation2021.Temmuz2021_C6 = employee.Vacation2021.Temmuz2021_C6;

            vacation2021.Agustos2021_C1 = employee.Vacation2021.Agustos2021_C1;
            vacation2021.Agustos2021_C2 = employee.Vacation2021.Agustos2021_C2;
            vacation2021.Agustos2021_C3 = employee.Vacation2021.Agustos2021_C3;
            vacation2021.Agustos2021_C4 = employee.Vacation2021.Agustos2021_C4;
            vacation2021.Agustos2021_C5 = employee.Vacation2021.Agustos2021_C5;
            vacation2021.Agustos2021_C6 = employee.Vacation2021.Agustos2021_C6;

            vacation2021.Eylul2021_C1 = employee.Vacation2021.Eylul2021_C1;
            vacation2021.Eylul2021_C2 = employee.Vacation2021.Eylul2021_C2;
            vacation2021.Eylul2021_C3 = employee.Vacation2021.Eylul2021_C3;
            vacation2021.Eylul2021_C4 = employee.Vacation2021.Eylul2021_C4;
            vacation2021.Eylul2021_C5 = employee.Vacation2021.Eylul2021_C5;
            vacation2021.Eylul2021_C6 = employee.Vacation2021.Eylul2021_C6;

            vacation2021.Ekim2021_C1 = employee.Vacation2021.Ekim2021_C1;
            vacation2021.Ekim2021_C2 = employee.Vacation2021.Ekim2021_C2;
            vacation2021.Ekim2021_C3 = employee.Vacation2021.Ekim2021_C3;
            vacation2021.Ekim2021_C4 = employee.Vacation2021.Ekim2021_C4;
            vacation2021.Ekim2021_C5 = employee.Vacation2021.Ekim2021_C5;
            vacation2021.Ekim2021_C6 = employee.Vacation2021.Ekim2021_C6;

            vacation2021.Kasim2021_C1 = employee.Vacation2021.Kasim2021_C1;
            vacation2021.Kasim2021_C2 = employee.Vacation2021.Kasim2021_C2;
            vacation2021.Kasim2021_C3 = employee.Vacation2021.Kasim2021_C3;
            vacation2021.Kasim2021_C4 = employee.Vacation2021.Kasim2021_C4;
            vacation2021.Kasim2021_C5 = employee.Vacation2021.Kasim2021_C5;
            vacation2021.Kasim2021_C6 = employee.Vacation2021.Kasim2021_C6;

            vacation2021.Aralik2021_C1 = employee.Vacation2021.Aralik2021_C1;
            vacation2021.Aralik2021_C2 = employee.Vacation2021.Aralik2021_C2;
            vacation2021.Aralik2021_C3 = employee.Vacation2021.Aralik2021_C3;
            vacation2021.Aralik2021_C4 = employee.Vacation2021.Aralik2021_C4;
            vacation2021.Aralik2021_C5 = employee.Vacation2021.Aralik2021_C5;
            vacation2021.Aralik2021_C6 = employee.Vacation2021.Aralik2021_C6;
            #endregion

            #region VACATION 2022

            vacation2022.Ocak2022_C1 = employee.Vacation2022.Ocak2022_C1;
            vacation2022.Ocak2022_C2 = employee.Vacation2022.Ocak2022_C2;
            vacation2022.Ocak2022_C3 = employee.Vacation2022.Ocak2022_C3;
            vacation2022.Ocak2022_C4 = employee.Vacation2022.Ocak2022_C4;
            vacation2022.Ocak2022_C5 = employee.Vacation2022.Ocak2022_C5;
            vacation2022.Ocak2022_C6 = employee.Vacation2022.Ocak2022_C6;

            vacation2022.Subat2022_C1 = employee.Vacation2022.Subat2022_C1;
            vacation2022.Subat2022_C2 = employee.Vacation2022.Subat2022_C2;
            vacation2022.Subat2022_C3 = employee.Vacation2022.Subat2022_C3;
            vacation2022.Subat2022_C4 = employee.Vacation2022.Subat2022_C4;
            vacation2022.Subat2022_C5 = employee.Vacation2022.Subat2022_C5;
            vacation2022.Subat2022_C6 = employee.Vacation2022.Subat2022_C6;

            vacation2022.Mart2022_C1 = employee.Vacation2022.Mart2022_C1;
            vacation2022.Mart2022_C2 = employee.Vacation2022.Mart2022_C2;
            vacation2022.Mart2022_C3 = employee.Vacation2022.Mart2022_C3;
            vacation2022.Mart2022_C4 = employee.Vacation2022.Mart2022_C4;
            vacation2022.Mart2022_C5 = employee.Vacation2022.Mart2022_C5;
            vacation2022.Mart2022_C6 = employee.Vacation2022.Mart2022_C6;

            vacation2022.Nisan2022_C1 = employee.Vacation2022.Nisan2022_C1;
            vacation2022.Nisan2022_C2 = employee.Vacation2022.Nisan2022_C2;
            vacation2022.Nisan2022_C3 = employee.Vacation2022.Nisan2022_C3;
            vacation2022.Nisan2022_C4 = employee.Vacation2022.Nisan2022_C4;
            vacation2022.Nisan2022_C5 = employee.Vacation2022.Nisan2022_C5;
            vacation2022.Nisan2022_C6 = employee.Vacation2022.Nisan2022_C6;

            vacation2022.Mayis2022_C1 = employee.Vacation2022.Mayis2022_C1;
            vacation2022.Mayis2022_C2 = employee.Vacation2022.Mayis2022_C2;
            vacation2022.Mayis2022_C3 = employee.Vacation2022.Mayis2022_C3;
            vacation2022.Mayis2022_C4 = employee.Vacation2022.Mayis2022_C4;
            vacation2022.Mayis2022_C5 = employee.Vacation2022.Mayis2022_C5;
            vacation2022.Mayis2022_C6 = employee.Vacation2022.Mayis2022_C6;

            vacation2022.Haziran2022_C1 = employee.Vacation2022.Haziran2022_C1;
            vacation2022.Haziran2022_C2 = employee.Vacation2022.Haziran2022_C2;
            vacation2022.Haziran2022_C3 = employee.Vacation2022.Haziran2022_C3;
            vacation2022.Haziran2022_C4 = employee.Vacation2022.Haziran2022_C4;
            vacation2022.Haziran2022_C5 = employee.Vacation2022.Haziran2022_C5;
            vacation2022.Haziran2022_C6 = employee.Vacation2022.Haziran2022_C6;

            vacation2022.Temmuz2022_C1 = employee.Vacation2022.Temmuz2022_C1;
            vacation2022.Temmuz2022_C2 = employee.Vacation2022.Temmuz2022_C2;
            vacation2022.Temmuz2022_C3 = employee.Vacation2022.Temmuz2022_C3;
            vacation2022.Temmuz2022_C4 = employee.Vacation2022.Temmuz2022_C4;
            vacation2022.Temmuz2022_C5 = employee.Vacation2022.Temmuz2022_C5;
            vacation2022.Temmuz2022_C6 = employee.Vacation2022.Temmuz2022_C6;

            vacation2022.Agustos2022_C1 = employee.Vacation2022.Agustos2022_C1;
            vacation2022.Agustos2022_C2 = employee.Vacation2022.Agustos2022_C2;
            vacation2022.Agustos2022_C3 = employee.Vacation2022.Agustos2022_C3;
            vacation2022.Agustos2022_C4 = employee.Vacation2022.Agustos2022_C4;
            vacation2022.Agustos2022_C5 = employee.Vacation2022.Agustos2022_C5;
            vacation2022.Agustos2022_C6 = employee.Vacation2022.Agustos2022_C6;

            vacation2022.Eylul2022_C1 = employee.Vacation2022.Eylul2022_C1;
            vacation2022.Eylul2022_C2 = employee.Vacation2022.Eylul2022_C2;
            vacation2022.Eylul2022_C3 = employee.Vacation2022.Eylul2022_C3;
            vacation2022.Eylul2022_C4 = employee.Vacation2022.Eylul2022_C4;
            vacation2022.Eylul2022_C5 = employee.Vacation2022.Eylul2022_C5;
            vacation2022.Eylul2022_C6 = employee.Vacation2022.Eylul2022_C6;

            vacation2022.Ekim2022_C1 = employee.Vacation2022.Ekim2022_C1;
            vacation2022.Ekim2022_C2 = employee.Vacation2022.Ekim2022_C2;
            vacation2022.Ekim2022_C3 = employee.Vacation2022.Ekim2022_C3;
            vacation2022.Ekim2022_C4 = employee.Vacation2022.Ekim2022_C4;
            vacation2022.Ekim2022_C5 = employee.Vacation2022.Ekim2022_C5;
            vacation2022.Ekim2022_C6 = employee.Vacation2022.Ekim2022_C6;

            vacation2022.Kasim2022_C1 = employee.Vacation2022.Kasim2022_C1;
            vacation2022.Kasim2022_C2 = employee.Vacation2022.Kasim2022_C2;
            vacation2022.Kasim2022_C3 = employee.Vacation2022.Kasim2022_C3;
            vacation2022.Kasim2022_C4 = employee.Vacation2022.Kasim2022_C4;
            vacation2022.Kasim2022_C5 = employee.Vacation2022.Kasim2022_C5;
            vacation2022.Kasim2022_C6 = employee.Vacation2022.Kasim2022_C6;

            vacation2022.Aralik2022_C1 = employee.Vacation2022.Aralik2022_C1;
            vacation2022.Aralik2022_C2 = employee.Vacation2022.Aralik2022_C2;
            vacation2022.Aralik2022_C3 = employee.Vacation2022.Aralik2022_C3;
            vacation2022.Aralik2022_C4 = employee.Vacation2022.Aralik2022_C4;
            vacation2022.Aralik2022_C5 = employee.Vacation2022.Aralik2022_C5;
            vacation2022.Aralik2022_C6 = employee.Vacation2022.Aralik2022_C6;
            #endregion

            #region VACATION 2023

            vacation2023.Ocak2023_C1 = employee.Vacation2023.Ocak2023_C1;
            vacation2023.Ocak2023_C2 = employee.Vacation2023.Ocak2023_C2;
            vacation2023.Ocak2023_C3 = employee.Vacation2023.Ocak2023_C3;
            vacation2023.Ocak2023_C4 = employee.Vacation2023.Ocak2023_C4;
            vacation2023.Ocak2023_C5 = employee.Vacation2023.Ocak2023_C5;
            vacation2023.Ocak2023_C6 = employee.Vacation2023.Ocak2023_C6;

            vacation2023.Subat2023_C1 = employee.Vacation2023.Subat2023_C1;
            vacation2023.Subat2023_C2 = employee.Vacation2023.Subat2023_C2;
            vacation2023.Subat2023_C3 = employee.Vacation2023.Subat2023_C3;
            vacation2023.Subat2023_C4 = employee.Vacation2023.Subat2023_C4;
            vacation2023.Subat2023_C5 = employee.Vacation2023.Subat2023_C5;
            vacation2023.Subat2023_C6 = employee.Vacation2023.Subat2023_C6;

            vacation2023.Mart2023_C1 = employee.Vacation2023.Mart2023_C1;
            vacation2023.Mart2023_C2 = employee.Vacation2023.Mart2023_C2;
            vacation2023.Mart2023_C3 = employee.Vacation2023.Mart2023_C3;
            vacation2023.Mart2023_C4 = employee.Vacation2023.Mart2023_C4;
            vacation2023.Mart2023_C5 = employee.Vacation2023.Mart2023_C5;
            vacation2023.Mart2023_C6 = employee.Vacation2023.Mart2023_C6;

            vacation2023.Nisan2023_C1 = employee.Vacation2023.Nisan2023_C1;
            vacation2023.Nisan2023_C2 = employee.Vacation2023.Nisan2023_C2;
            vacation2023.Nisan2023_C3 = employee.Vacation2023.Nisan2023_C3;
            vacation2023.Nisan2023_C4 = employee.Vacation2023.Nisan2023_C4;
            vacation2023.Nisan2023_C5 = employee.Vacation2023.Nisan2023_C5;
            vacation2023.Nisan2023_C6 = employee.Vacation2023.Nisan2023_C6;

            vacation2023.Mayis2023_C1 = employee.Vacation2023.Mayis2023_C1;
            vacation2023.Mayis2023_C2 = employee.Vacation2023.Mayis2023_C2;
            vacation2023.Mayis2023_C3 = employee.Vacation2023.Mayis2023_C3;
            vacation2023.Mayis2023_C4 = employee.Vacation2023.Mayis2023_C4;
            vacation2023.Mayis2023_C5 = employee.Vacation2023.Mayis2023_C5;
            vacation2023.Mayis2023_C6 = employee.Vacation2023.Mayis2023_C6;

            vacation2023.Haziran2023_C1 = employee.Vacation2023.Haziran2023_C1;
            vacation2023.Haziran2023_C2 = employee.Vacation2023.Haziran2023_C2;
            vacation2023.Haziran2023_C3 = employee.Vacation2023.Haziran2023_C3;
            vacation2023.Haziran2023_C4 = employee.Vacation2023.Haziran2023_C4;
            vacation2023.Haziran2023_C5 = employee.Vacation2023.Haziran2023_C5;
            vacation2023.Haziran2023_C6 = employee.Vacation2023.Haziran2023_C6;

            vacation2023.Temmuz2023_C1 = employee.Vacation2023.Temmuz2023_C1;
            vacation2023.Temmuz2023_C2 = employee.Vacation2023.Temmuz2023_C2;
            vacation2023.Temmuz2023_C3 = employee.Vacation2023.Temmuz2023_C3;
            vacation2023.Temmuz2023_C4 = employee.Vacation2023.Temmuz2023_C4;
            vacation2023.Temmuz2023_C5 = employee.Vacation2023.Temmuz2023_C5;
            vacation2023.Temmuz2023_C6 = employee.Vacation2023.Temmuz2023_C6;

            vacation2023.Agustos2023_C1 = employee.Vacation2023.Agustos2023_C1;
            vacation2023.Agustos2023_C2 = employee.Vacation2023.Agustos2023_C2;
            vacation2023.Agustos2023_C3 = employee.Vacation2023.Agustos2023_C3;
            vacation2023.Agustos2023_C4 = employee.Vacation2023.Agustos2023_C4;
            vacation2023.Agustos2023_C5 = employee.Vacation2023.Agustos2023_C5;
            vacation2023.Agustos2023_C6 = employee.Vacation2023.Agustos2023_C6;

            vacation2023.Eylul2023_C1 = employee.Vacation2023.Eylul2023_C1;
            vacation2023.Eylul2023_C2 = employee.Vacation2023.Eylul2023_C2;
            vacation2023.Eylul2023_C3 = employee.Vacation2023.Eylul2023_C3;
            vacation2023.Eylul2023_C4 = employee.Vacation2023.Eylul2023_C4;
            vacation2023.Eylul2023_C5 = employee.Vacation2023.Eylul2023_C5;
            vacation2023.Eylul2023_C6 = employee.Vacation2023.Eylul2023_C6;

            vacation2023.Ekim2023_C1 = employee.Vacation2023.Ekim2023_C1;
            vacation2023.Ekim2023_C2 = employee.Vacation2023.Ekim2023_C2;
            vacation2023.Ekim2023_C3 = employee.Vacation2023.Ekim2023_C3;
            vacation2023.Ekim2023_C4 = employee.Vacation2023.Ekim2023_C4;
            vacation2023.Ekim2023_C5 = employee.Vacation2023.Ekim2023_C5;
            vacation2023.Ekim2023_C6 = employee.Vacation2023.Ekim2023_C6;

            vacation2023.Kasim2023_C1 = employee.Vacation2023.Kasim2023_C1;
            vacation2023.Kasim2023_C2 = employee.Vacation2023.Kasim2023_C2;
            vacation2023.Kasim2023_C3 = employee.Vacation2023.Kasim2023_C3;
            vacation2023.Kasim2023_C4 = employee.Vacation2023.Kasim2023_C4;
            vacation2023.Kasim2023_C5 = employee.Vacation2023.Kasim2023_C5;
            vacation2023.Kasim2023_C6 = employee.Vacation2023.Kasim2023_C6;

            vacation2023.Aralik2023_C1 = employee.Vacation2023.Aralik2023_C1;
            vacation2023.Aralik2023_C2 = employee.Vacation2023.Aralik2023_C2;
            vacation2023.Aralik2023_C3 = employee.Vacation2023.Aralik2023_C3;
            vacation2023.Aralik2023_C4 = employee.Vacation2023.Aralik2023_C4;
            vacation2023.Aralik2023_C5 = employee.Vacation2023.Aralik2023_C5;
            vacation2023.Aralik2023_C6 = employee.Vacation2023.Aralik2023_C6;
            #endregion

            await context.SaveChangesAsync();
    }
}
}
