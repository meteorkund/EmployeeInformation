using EmployeeInformation.Domain.Models;
using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands;

public class EditEmployeeCommand : AsyncCommandBase
{
    readonly EditEmployeeViewModel _editEmployeeViewModel;
    readonly ModalNavigationStore _modalNavigationStore;
    readonly EmployeeStore _employeeStore;

    public EditEmployeeCommand(EditEmployeeViewModel editEmployeeViewModel, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
    {
        _editEmployeeViewModel = editEmployeeViewModel;
        _employeeStore = employeeStore;
        _modalNavigationStore = modalNavigationStore;
    }

    public override async Task ExecuteAsync(object parameter)
    {
        EmployeeDetailsFormViewModel formViewModel = _editEmployeeViewModel.EmployeeDetailsFormViewModel;

        formViewModel.ErrorMessage = null;
        formViewModel.IsSubmitting = true;
        formViewModel.IsSaved = true;
        formViewModel.SaveStatus = "GÜNCELLENİYOR...";

        Employee employee = new Employee
        {
            Id = _editEmployeeViewModel.EmployeeId,
            Fotograf = formViewModel.PhotoSource,
            Isim = formViewModel.Isim,
            Soyisim = formViewModel.Soyisim,
            Durum = formViewModel.Durum,
            TCKimlik = formViewModel.TCKimlik,
            DogumTarihi = formViewModel.DogumTarihi,

            Departman = new Department(formViewModel.SelectedDepartmentItem.DepartmentId, formViewModel.SelectedDepartmentItem.DepartmentName),
            Sector = new Sector(formViewModel.SelectedSectorItem.SectorId, formViewModel.SelectedSectorItem.SectorName),
            Education = new Education(formViewModel.SelectedEducationItem.EducationId, formViewModel.SelectedEducationItem.EducationDegree),
            Military = new MilitaryServiceStatus(formViewModel.SelectedMilitaryServiceItem.MilitaryServiceId, formViewModel.SelectedMilitaryServiceItem.MilitaryStatus),
            Maritial = new Maritial(formViewModel.SelectedMaritialStatusItem.MaritialStatusId, formViewModel.SelectedMaritialStatusItem.MaritialStatusName),


            Gorev = formViewModel.Gorev,
            IseGiris = formViewModel.IseGiris,
            IstenCikis = formViewModel.IstenCikis,
            Maas = formViewModel.Maas,
            CepTel = formViewModel.CepTel,
            CalismaSuresi = formViewModel.CalismaSuresi,
            BaslamaTarihi = formViewModel.BaslamaTarihi,
            Adres = formViewModel.EvAdresi,
            EkBilgi = formViewModel.EkBilgi,

            Vacation2018 = new Vacation2018
            {
                Ocak2018_C1 = formViewModel.Ocak2018_C1,
                Ocak2018_C2 = formViewModel.Ocak2018_C2,
                Ocak2018_C3 = formViewModel.Ocak2018_C3,
                Ocak2018_C4 = formViewModel.Ocak2018_C4,
                Ocak2018_C5 = formViewModel.Ocak2018_C5,
                Ocak2018_C6 = formViewModel.Ocak2018_C6,

                Subat2018_C1 = formViewModel.Subat2018_C1,
                Subat2018_C2 = formViewModel.Subat2018_C2,
                Subat2018_C3 = formViewModel.Subat2018_C3,
                Subat2018_C4 = formViewModel.Subat2018_C4,
                Subat2018_C5 = formViewModel.Subat2018_C5,
                Subat2018_C6 = formViewModel.Subat2018_C6,

                Mart2018_C1 = formViewModel.Mart2018_C1,
                Mart2018_C2 = formViewModel.Mart2018_C2,
                Mart2018_C3 = formViewModel.Mart2018_C3,
                Mart2018_C4 = formViewModel.Mart2018_C4,
                Mart2018_C5 = formViewModel.Mart2018_C5,
                Mart2018_C6 = formViewModel.Mart2018_C6,

                Nisan2018_C1 = formViewModel.Nisan2018_C1,
                Nisan2018_C2 = formViewModel.Nisan2018_C2,
                Nisan2018_C3 = formViewModel.Nisan2018_C3,
                Nisan2018_C4 = formViewModel.Nisan2018_C4,
                Nisan2018_C5 = formViewModel.Nisan2018_C5,
                Nisan2018_C6 = formViewModel.Nisan2018_C6,

                Mayis2018_C1 = formViewModel.Mayis2018_C1,
                Mayis2018_C2 = formViewModel.Mayis2018_C2,
                Mayis2018_C3 = formViewModel.Mayis2018_C3,
                Mayis2018_C4 = formViewModel.Mayis2018_C4,
                Mayis2018_C5 = formViewModel.Mayis2018_C5,
                Mayis2018_C6 = formViewModel.Mayis2018_C6,

                Haziran2018_C1 = formViewModel.Haziran2018_C1,
                Haziran2018_C2 = formViewModel.Haziran2018_C2,
                Haziran2018_C3 = formViewModel.Haziran2018_C3,
                Haziran2018_C4 = formViewModel.Haziran2018_C4,
                Haziran2018_C5 = formViewModel.Haziran2018_C5,
                Haziran2018_C6 = formViewModel.Haziran2018_C6,

                Temmuz2018_C1 = formViewModel.Temmuz2018_C1,
                Temmuz2018_C2 = formViewModel.Temmuz2018_C2,
                Temmuz2018_C3 = formViewModel.Temmuz2018_C3,
                Temmuz2018_C4 = formViewModel.Temmuz2018_C4,
                Temmuz2018_C5 = formViewModel.Temmuz2018_C5,
                Temmuz2018_C6 = formViewModel.Temmuz2018_C6,

                Agustos2018_C1 = formViewModel.Agustos2018_C1,
                Agustos2018_C2 = formViewModel.Agustos2018_C2,
                Agustos2018_C3 = formViewModel.Agustos2018_C3,
                Agustos2018_C4 = formViewModel.Agustos2018_C4,
                Agustos2018_C5 = formViewModel.Agustos2018_C5,
                Agustos2018_C6 = formViewModel.Agustos2018_C6,

                Eylul2018_C1 = formViewModel.Eylul2018_C1,
                Eylul2018_C2 = formViewModel.Eylul2018_C2,
                Eylul2018_C3 = formViewModel.Eylul2018_C3,
                Eylul2018_C4 = formViewModel.Eylul2018_C4,
                Eylul2018_C5 = formViewModel.Eylul2018_C5,
                Eylul2018_C6 = formViewModel.Eylul2018_C6,

                Ekim2018_C1 = formViewModel.Ekim2018_C1,
                Ekim2018_C2 = formViewModel.Ekim2018_C2,
                Ekim2018_C3 = formViewModel.Ekim2018_C3,
                Ekim2018_C4 = formViewModel.Ekim2018_C4,
                Ekim2018_C5 = formViewModel.Ekim2018_C5,
                Ekim2018_C6 = formViewModel.Ekim2018_C6,

                Kasim2018_C1 = formViewModel.Kasim2018_C1,
                Kasim2018_C2 = formViewModel.Kasim2018_C2,
                Kasim2018_C3 = formViewModel.Kasim2018_C3,
                Kasim2018_C4 = formViewModel.Kasim2018_C4,
                Kasim2018_C5 = formViewModel.Kasim2018_C5,
                Kasim2018_C6 = formViewModel.Kasim2018_C6,

                Aralik2018_C1 = formViewModel.Aralik2018_C1,
                Aralik2018_C2 = formViewModel.Aralik2018_C2,
                Aralik2018_C3 = formViewModel.Aralik2018_C3,
                Aralik2018_C4 = formViewModel.Aralik2018_C4,
                Aralik2018_C5 = formViewModel.Aralik2018_C5,
                Aralik2018_C6 = formViewModel.Aralik2018_C6,
            },
            Vacation2019 = new Vacation2019
            {
                Ocak2019_C1 = formViewModel.Ocak2019_C1,
                Ocak2019_C2 = formViewModel.Ocak2019_C2,
                Ocak2019_C3 = formViewModel.Ocak2019_C3,
                Ocak2019_C4 = formViewModel.Ocak2019_C4,
                Ocak2019_C5 = formViewModel.Ocak2019_C5,
                Ocak2019_C6 = formViewModel.Ocak2019_C6,

                Subat2019_C1 = formViewModel.Subat2019_C1,
                Subat2019_C2 = formViewModel.Subat2019_C2,
                Subat2019_C3 = formViewModel.Subat2019_C3,
                Subat2019_C4 = formViewModel.Subat2019_C4,
                Subat2019_C5 = formViewModel.Subat2019_C5,
                Subat2019_C6 = formViewModel.Subat2019_C6,

                Mart2019_C1 = formViewModel.Mart2019_C1,
                Mart2019_C2 = formViewModel.Mart2019_C2,
                Mart2019_C3 = formViewModel.Mart2019_C3,
                Mart2019_C4 = formViewModel.Mart2019_C4,
                Mart2019_C5 = formViewModel.Mart2019_C5,
                Mart2019_C6 = formViewModel.Mart2019_C6,

                Nisan2019_C1 = formViewModel.Nisan2019_C1,
                Nisan2019_C2 = formViewModel.Nisan2019_C2,
                Nisan2019_C3 = formViewModel.Nisan2019_C3,
                Nisan2019_C4 = formViewModel.Nisan2019_C4,
                Nisan2019_C5 = formViewModel.Nisan2019_C5,
                Nisan2019_C6 = formViewModel.Nisan2019_C6,

                Mayis2019_C1 = formViewModel.Mayis2019_C1,
                Mayis2019_C2 = formViewModel.Mayis2019_C2,
                Mayis2019_C3 = formViewModel.Mayis2019_C3,
                Mayis2019_C4 = formViewModel.Mayis2019_C4,
                Mayis2019_C5 = formViewModel.Mayis2019_C5,
                Mayis2019_C6 = formViewModel.Mayis2019_C6,

                Haziran2019_C1 = formViewModel.Haziran2019_C1,
                Haziran2019_C2 = formViewModel.Haziran2019_C2,
                Haziran2019_C3 = formViewModel.Haziran2019_C3,
                Haziran2019_C4 = formViewModel.Haziran2019_C4,
                Haziran2019_C5 = formViewModel.Haziran2019_C5,
                Haziran2019_C6 = formViewModel.Haziran2019_C6,

                Temmuz2019_C1 = formViewModel.Temmuz2019_C1,
                Temmuz2019_C2 = formViewModel.Temmuz2019_C2,
                Temmuz2019_C3 = formViewModel.Temmuz2019_C3,
                Temmuz2019_C4 = formViewModel.Temmuz2019_C4,
                Temmuz2019_C5 = formViewModel.Temmuz2019_C5,
                Temmuz2019_C6 = formViewModel.Temmuz2019_C6,

                Agustos2019_C1 = formViewModel.Agustos2019_C1,
                Agustos2019_C2 = formViewModel.Agustos2019_C2,
                Agustos2019_C3 = formViewModel.Agustos2019_C3,
                Agustos2019_C4 = formViewModel.Agustos2019_C4,
                Agustos2019_C5 = formViewModel.Agustos2019_C5,
                Agustos2019_C6 = formViewModel.Agustos2019_C6,

                Eylul2019_C1 = formViewModel.Eylul2019_C1,
                Eylul2019_C2 = formViewModel.Eylul2019_C2,
                Eylul2019_C3 = formViewModel.Eylul2019_C3,
                Eylul2019_C4 = formViewModel.Eylul2019_C4,
                Eylul2019_C5 = formViewModel.Eylul2019_C5,
                Eylul2019_C6 = formViewModel.Eylul2019_C6,

                Ekim2019_C1 = formViewModel.Ekim2019_C1,
                Ekim2019_C2 = formViewModel.Ekim2019_C2,
                Ekim2019_C3 = formViewModel.Ekim2019_C3,
                Ekim2019_C4 = formViewModel.Ekim2019_C4,
                Ekim2019_C5 = formViewModel.Ekim2019_C5,
                Ekim2019_C6 = formViewModel.Ekim2019_C6,

                Kasim2019_C1 = formViewModel.Kasim2019_C1,
                Kasim2019_C2 = formViewModel.Kasim2019_C2,
                Kasim2019_C3 = formViewModel.Kasim2019_C3,
                Kasim2019_C4 = formViewModel.Kasim2019_C4,
                Kasim2019_C5 = formViewModel.Kasim2019_C5,
                Kasim2019_C6 = formViewModel.Kasim2019_C6,

                Aralik2019_C1 = formViewModel.Aralik2019_C1,
                Aralik2019_C2 = formViewModel.Aralik2019_C2,
                Aralik2019_C3 = formViewModel.Aralik2019_C3,
                Aralik2019_C4 = formViewModel.Aralik2019_C4,
                Aralik2019_C5 = formViewModel.Aralik2019_C5,
                Aralik2019_C6 = formViewModel.Aralik2019_C6,
            },
            Vacation2020 = new Vacation2020
            {
                Ocak2020_C1 = formViewModel.Ocak2020_C1,
                Ocak2020_C2 = formViewModel.Ocak2020_C2,
                Ocak2020_C3 = formViewModel.Ocak2020_C3,
                Ocak2020_C4 = formViewModel.Ocak2020_C4,
                Ocak2020_C5 = formViewModel.Ocak2020_C5,
                Ocak2020_C6 = formViewModel.Ocak2020_C6,

                Subat2020_C1 = formViewModel.Subat2020_C1,
                Subat2020_C2 = formViewModel.Subat2020_C2,
                Subat2020_C3 = formViewModel.Subat2020_C3,
                Subat2020_C4 = formViewModel.Subat2020_C4,
                Subat2020_C5 = formViewModel.Subat2020_C5,
                Subat2020_C6 = formViewModel.Subat2020_C6,

                Mart2020_C1 = formViewModel.Mart2020_C1,
                Mart2020_C2 = formViewModel.Mart2020_C2,
                Mart2020_C3 = formViewModel.Mart2020_C3,
                Mart2020_C4 = formViewModel.Mart2020_C4,
                Mart2020_C5 = formViewModel.Mart2020_C5,
                Mart2020_C6 = formViewModel.Mart2020_C6,

                Nisan2020_C1 = formViewModel.Nisan2020_C1,
                Nisan2020_C2 = formViewModel.Nisan2020_C2,
                Nisan2020_C3 = formViewModel.Nisan2020_C3,
                Nisan2020_C4 = formViewModel.Nisan2020_C4,
                Nisan2020_C5 = formViewModel.Nisan2020_C5,
                Nisan2020_C6 = formViewModel.Nisan2020_C6,

                Mayis2020_C1 = formViewModel.Mayis2020_C1,
                Mayis2020_C2 = formViewModel.Mayis2020_C2,
                Mayis2020_C3 = formViewModel.Mayis2020_C3,
                Mayis2020_C4 = formViewModel.Mayis2020_C4,
                Mayis2020_C5 = formViewModel.Mayis2020_C5,
                Mayis2020_C6 = formViewModel.Mayis2020_C6,

                Haziran2020_C1 = formViewModel.Haziran2020_C1,
                Haziran2020_C2 = formViewModel.Haziran2020_C2,
                Haziran2020_C3 = formViewModel.Haziran2020_C3,
                Haziran2020_C4 = formViewModel.Haziran2020_C4,
                Haziran2020_C5 = formViewModel.Haziran2020_C5,
                Haziran2020_C6 = formViewModel.Haziran2020_C6,

                Temmuz2020_C1 = formViewModel.Temmuz2020_C1,
                Temmuz2020_C2 = formViewModel.Temmuz2020_C2,
                Temmuz2020_C3 = formViewModel.Temmuz2020_C3,
                Temmuz2020_C4 = formViewModel.Temmuz2020_C4,
                Temmuz2020_C5 = formViewModel.Temmuz2020_C5,
                Temmuz2020_C6 = formViewModel.Temmuz2020_C6,

                Agustos2020_C1 = formViewModel.Agustos2020_C1,
                Agustos2020_C2 = formViewModel.Agustos2020_C2,
                Agustos2020_C3 = formViewModel.Agustos2020_C3,
                Agustos2020_C4 = formViewModel.Agustos2020_C4,
                Agustos2020_C5 = formViewModel.Agustos2020_C5,
                Agustos2020_C6 = formViewModel.Agustos2020_C6,

                Eylul2020_C1 = formViewModel.Eylul2020_C1,
                Eylul2020_C2 = formViewModel.Eylul2020_C2,
                Eylul2020_C3 = formViewModel.Eylul2020_C3,
                Eylul2020_C4 = formViewModel.Eylul2020_C4,
                Eylul2020_C5 = formViewModel.Eylul2020_C5,
                Eylul2020_C6 = formViewModel.Eylul2020_C6,

                Ekim2020_C1 = formViewModel.Ekim2020_C1,
                Ekim2020_C2 = formViewModel.Ekim2020_C2,
                Ekim2020_C3 = formViewModel.Ekim2020_C3,
                Ekim2020_C4 = formViewModel.Ekim2020_C4,
                Ekim2020_C5 = formViewModel.Ekim2020_C5,
                Ekim2020_C6 = formViewModel.Ekim2020_C6,

                Kasim2020_C1 = formViewModel.Kasim2020_C1,
                Kasim2020_C2 = formViewModel.Kasim2020_C2,
                Kasim2020_C3 = formViewModel.Kasim2020_C3,
                Kasim2020_C4 = formViewModel.Kasim2020_C4,
                Kasim2020_C5 = formViewModel.Kasim2020_C5,
                Kasim2020_C6 = formViewModel.Kasim2020_C6,

                Aralik2020_C1 = formViewModel.Aralik2020_C1,
                Aralik2020_C2 = formViewModel.Aralik2020_C2,
                Aralik2020_C3 = formViewModel.Aralik2020_C3,
                Aralik2020_C4 = formViewModel.Aralik2020_C4,
                Aralik2020_C5 = formViewModel.Aralik2020_C5,
                Aralik2020_C6 = formViewModel.Aralik2020_C6,
            },
            Vacation2021 = new Vacation2021
            {
                Ocak2021_C1 = formViewModel.Ocak2021_C1,
                Ocak2021_C2 = formViewModel.Ocak2021_C2,
                Ocak2021_C3 = formViewModel.Ocak2021_C3,
                Ocak2021_C4 = formViewModel.Ocak2021_C4,
                Ocak2021_C5 = formViewModel.Ocak2021_C5,
                Ocak2021_C6 = formViewModel.Ocak2021_C6,

                Subat2021_C1 = formViewModel.Subat2021_C1,
                Subat2021_C2 = formViewModel.Subat2021_C2,
                Subat2021_C3 = formViewModel.Subat2021_C3,
                Subat2021_C4 = formViewModel.Subat2021_C4,
                Subat2021_C5 = formViewModel.Subat2021_C5,
                Subat2021_C6 = formViewModel.Subat2021_C6,

                Mart2021_C1 = formViewModel.Mart2021_C1,
                Mart2021_C2 = formViewModel.Mart2021_C2,
                Mart2021_C3 = formViewModel.Mart2021_C3,
                Mart2021_C4 = formViewModel.Mart2021_C4,
                Mart2021_C5 = formViewModel.Mart2021_C5,
                Mart2021_C6 = formViewModel.Mart2021_C6,

                Nisan2021_C1 = formViewModel.Nisan2021_C1,
                Nisan2021_C2 = formViewModel.Nisan2021_C2,
                Nisan2021_C3 = formViewModel.Nisan2021_C3,
                Nisan2021_C4 = formViewModel.Nisan2021_C4,
                Nisan2021_C5 = formViewModel.Nisan2021_C5,
                Nisan2021_C6 = formViewModel.Nisan2021_C6,

                Mayis2021_C1 = formViewModel.Mayis2021_C1,
                Mayis2021_C2 = formViewModel.Mayis2021_C2,
                Mayis2021_C3 = formViewModel.Mayis2021_C3,
                Mayis2021_C4 = formViewModel.Mayis2021_C4,
                Mayis2021_C5 = formViewModel.Mayis2021_C5,
                Mayis2021_C6 = formViewModel.Mayis2021_C6,

                Haziran2021_C1 = formViewModel.Haziran2021_C1,
                Haziran2021_C2 = formViewModel.Haziran2021_C2,
                Haziran2021_C3 = formViewModel.Haziran2021_C3,
                Haziran2021_C4 = formViewModel.Haziran2021_C4,
                Haziran2021_C5 = formViewModel.Haziran2021_C5,
                Haziran2021_C6 = formViewModel.Haziran2021_C6,

                Temmuz2021_C1 = formViewModel.Temmuz2021_C1,
                Temmuz2021_C2 = formViewModel.Temmuz2021_C2,
                Temmuz2021_C3 = formViewModel.Temmuz2021_C3,
                Temmuz2021_C4 = formViewModel.Temmuz2021_C4,
                Temmuz2021_C5 = formViewModel.Temmuz2021_C5,
                Temmuz2021_C6 = formViewModel.Temmuz2021_C6,

                Agustos2021_C1 = formViewModel.Agustos2021_C1,
                Agustos2021_C2 = formViewModel.Agustos2021_C2,
                Agustos2021_C3 = formViewModel.Agustos2021_C3,
                Agustos2021_C4 = formViewModel.Agustos2021_C4,
                Agustos2021_C5 = formViewModel.Agustos2021_C5,
                Agustos2021_C6 = formViewModel.Agustos2021_C6,

                Eylul2021_C1 = formViewModel.Eylul2021_C1,
                Eylul2021_C2 = formViewModel.Eylul2021_C2,
                Eylul2021_C3 = formViewModel.Eylul2021_C3,
                Eylul2021_C4 = formViewModel.Eylul2021_C4,
                Eylul2021_C5 = formViewModel.Eylul2021_C5,
                Eylul2021_C6 = formViewModel.Eylul2021_C6,

                Ekim2021_C1 = formViewModel.Ekim2021_C1,
                Ekim2021_C2 = formViewModel.Ekim2021_C2,
                Ekim2021_C3 = formViewModel.Ekim2021_C3,
                Ekim2021_C4 = formViewModel.Ekim2021_C4,
                Ekim2021_C5 = formViewModel.Ekim2021_C5,
                Ekim2021_C6 = formViewModel.Ekim2021_C6,

                Kasim2021_C1 = formViewModel.Kasim2021_C1,
                Kasim2021_C2 = formViewModel.Kasim2021_C2,
                Kasim2021_C3 = formViewModel.Kasim2021_C3,
                Kasim2021_C4 = formViewModel.Kasim2021_C4,
                Kasim2021_C5 = formViewModel.Kasim2021_C5,
                Kasim2021_C6 = formViewModel.Kasim2021_C6,

                Aralik2021_C1 = formViewModel.Aralik2021_C1,
                Aralik2021_C2 = formViewModel.Aralik2021_C2,
                Aralik2021_C3 = formViewModel.Aralik2021_C3,
                Aralik2021_C4 = formViewModel.Aralik2021_C4,
                Aralik2021_C5 = formViewModel.Aralik2021_C5,
                Aralik2021_C6 = formViewModel.Aralik2021_C6,
            },
            Vacation2022 = new Vacation2022
            {
                Ocak2022_C1 = formViewModel.Ocak2022_C1,
                Ocak2022_C2 = formViewModel.Ocak2022_C2,
                Ocak2022_C3 = formViewModel.Ocak2022_C3,
                Ocak2022_C4 = formViewModel.Ocak2022_C4,
                Ocak2022_C5 = formViewModel.Ocak2022_C5,
                Ocak2022_C6 = formViewModel.Ocak2022_C6,

                Subat2022_C1 = formViewModel.Subat2022_C1,
                Subat2022_C2 = formViewModel.Subat2022_C2,
                Subat2022_C3 = formViewModel.Subat2022_C3,
                Subat2022_C4 = formViewModel.Subat2022_C4,
                Subat2022_C5 = formViewModel.Subat2022_C5,
                Subat2022_C6 = formViewModel.Subat2022_C6,

                Mart2022_C1 = formViewModel.Mart2022_C1,
                Mart2022_C2 = formViewModel.Mart2022_C2,
                Mart2022_C3 = formViewModel.Mart2022_C3,
                Mart2022_C4 = formViewModel.Mart2022_C4,
                Mart2022_C5 = formViewModel.Mart2022_C5,
                Mart2022_C6 = formViewModel.Mart2022_C6,

                Nisan2022_C1 = formViewModel.Nisan2022_C1,
                Nisan2022_C2 = formViewModel.Nisan2022_C2,
                Nisan2022_C3 = formViewModel.Nisan2022_C3,
                Nisan2022_C4 = formViewModel.Nisan2022_C4,
                Nisan2022_C5 = formViewModel.Nisan2022_C5,
                Nisan2022_C6 = formViewModel.Nisan2022_C6,

                Mayis2022_C1 = formViewModel.Mayis2022_C1,
                Mayis2022_C2 = formViewModel.Mayis2022_C2,
                Mayis2022_C3 = formViewModel.Mayis2022_C3,
                Mayis2022_C4 = formViewModel.Mayis2022_C4,
                Mayis2022_C5 = formViewModel.Mayis2022_C5,
                Mayis2022_C6 = formViewModel.Mayis2022_C6,

                Haziran2022_C1 = formViewModel.Haziran2022_C1,
                Haziran2022_C2 = formViewModel.Haziran2022_C2,
                Haziran2022_C3 = formViewModel.Haziran2022_C3,
                Haziran2022_C4 = formViewModel.Haziran2022_C4,
                Haziran2022_C5 = formViewModel.Haziran2022_C5,
                Haziran2022_C6 = formViewModel.Haziran2022_C6,

                Temmuz2022_C1 = formViewModel.Temmuz2022_C1,
                Temmuz2022_C2 = formViewModel.Temmuz2022_C2,
                Temmuz2022_C3 = formViewModel.Temmuz2022_C3,
                Temmuz2022_C4 = formViewModel.Temmuz2022_C4,
                Temmuz2022_C5 = formViewModel.Temmuz2022_C5,
                Temmuz2022_C6 = formViewModel.Temmuz2022_C6,

                Agustos2022_C1 = formViewModel.Agustos2022_C1,
                Agustos2022_C2 = formViewModel.Agustos2022_C2,
                Agustos2022_C3 = formViewModel.Agustos2022_C3,
                Agustos2022_C4 = formViewModel.Agustos2022_C4,
                Agustos2022_C5 = formViewModel.Agustos2022_C5,
                Agustos2022_C6 = formViewModel.Agustos2022_C6,

                Eylul2022_C1 = formViewModel.Eylul2022_C1,
                Eylul2022_C2 = formViewModel.Eylul2022_C2,
                Eylul2022_C3 = formViewModel.Eylul2022_C3,
                Eylul2022_C4 = formViewModel.Eylul2022_C4,
                Eylul2022_C5 = formViewModel.Eylul2022_C5,
                Eylul2022_C6 = formViewModel.Eylul2022_C6,

                Ekim2022_C1 = formViewModel.Ekim2022_C1,
                Ekim2022_C2 = formViewModel.Ekim2022_C2,
                Ekim2022_C3 = formViewModel.Ekim2022_C3,
                Ekim2022_C4 = formViewModel.Ekim2022_C4,
                Ekim2022_C5 = formViewModel.Ekim2022_C5,
                Ekim2022_C6 = formViewModel.Ekim2022_C6,

                Kasim2022_C1 = formViewModel.Kasim2022_C1,
                Kasim2022_C2 = formViewModel.Kasim2022_C2,
                Kasim2022_C3 = formViewModel.Kasim2022_C3,
                Kasim2022_C4 = formViewModel.Kasim2022_C4,
                Kasim2022_C5 = formViewModel.Kasim2022_C5,
                Kasim2022_C6 = formViewModel.Kasim2022_C6,

                Aralik2022_C1 = formViewModel.Aralik2022_C1,
                Aralik2022_C2 = formViewModel.Aralik2022_C2,
                Aralik2022_C3 = formViewModel.Aralik2022_C3,
                Aralik2022_C4 = formViewModel.Aralik2022_C4,
                Aralik2022_C5 = formViewModel.Aralik2022_C5,
                Aralik2022_C6 = formViewModel.Aralik2022_C6,
            },
            Vacation2023 = new Vacation2023
            {
                Ocak2023_C1 = formViewModel.Ocak2023_C1,
                Ocak2023_C2 = formViewModel.Ocak2023_C2,
                Ocak2023_C3 = formViewModel.Ocak2023_C3,
                Ocak2023_C4 = formViewModel.Ocak2023_C4,
                Ocak2023_C5 = formViewModel.Ocak2023_C5,
                Ocak2023_C6 = formViewModel.Ocak2023_C6,

                Subat2023_C1 = formViewModel.Subat2023_C1,
                Subat2023_C2 = formViewModel.Subat2023_C2,
                Subat2023_C3 = formViewModel.Subat2023_C3,
                Subat2023_C4 = formViewModel.Subat2023_C4,
                Subat2023_C5 = formViewModel.Subat2023_C5,
                Subat2023_C6 = formViewModel.Subat2023_C6,

                Mart2023_C1 = formViewModel.Mart2023_C1,
                Mart2023_C2 = formViewModel.Mart2023_C2,
                Mart2023_C3 = formViewModel.Mart2023_C3,
                Mart2023_C4 = formViewModel.Mart2023_C4,
                Mart2023_C5 = formViewModel.Mart2023_C5,
                Mart2023_C6 = formViewModel.Mart2023_C6,

                Nisan2023_C1 = formViewModel.Nisan2023_C1,
                Nisan2023_C2 = formViewModel.Nisan2023_C2,
                Nisan2023_C3 = formViewModel.Nisan2023_C3,
                Nisan2023_C4 = formViewModel.Nisan2023_C4,
                Nisan2023_C5 = formViewModel.Nisan2023_C5,
                Nisan2023_C6 = formViewModel.Nisan2023_C6,

                Mayis2023_C1 = formViewModel.Mayis2023_C1,
                Mayis2023_C2 = formViewModel.Mayis2023_C2,
                Mayis2023_C3 = formViewModel.Mayis2023_C3,
                Mayis2023_C4 = formViewModel.Mayis2023_C4,
                Mayis2023_C5 = formViewModel.Mayis2023_C5,
                Mayis2023_C6 = formViewModel.Mayis2023_C6,

                Haziran2023_C1 = formViewModel.Haziran2023_C1,
                Haziran2023_C2 = formViewModel.Haziran2023_C2,
                Haziran2023_C3 = formViewModel.Haziran2023_C3,
                Haziran2023_C4 = formViewModel.Haziran2023_C4,
                Haziran2023_C5 = formViewModel.Haziran2023_C5,
                Haziran2023_C6 = formViewModel.Haziran2023_C6,

                Temmuz2023_C1 = formViewModel.Temmuz2023_C1,
                Temmuz2023_C2 = formViewModel.Temmuz2023_C2,
                Temmuz2023_C3 = formViewModel.Temmuz2023_C3,
                Temmuz2023_C4 = formViewModel.Temmuz2023_C4,
                Temmuz2023_C5 = formViewModel.Temmuz2023_C5,
                Temmuz2023_C6 = formViewModel.Temmuz2023_C6,

                Agustos2023_C1 = formViewModel.Agustos2023_C1,
                Agustos2023_C2 = formViewModel.Agustos2023_C2,
                Agustos2023_C3 = formViewModel.Agustos2023_C3,
                Agustos2023_C4 = formViewModel.Agustos2023_C4,
                Agustos2023_C5 = formViewModel.Agustos2023_C5,
                Agustos2023_C6 = formViewModel.Agustos2023_C6,

                Eylul2023_C1 = formViewModel.Eylul2023_C1,
                Eylul2023_C2 = formViewModel.Eylul2023_C2,
                Eylul2023_C3 = formViewModel.Eylul2023_C3,
                Eylul2023_C4 = formViewModel.Eylul2023_C4,
                Eylul2023_C5 = formViewModel.Eylul2023_C5,
                Eylul2023_C6 = formViewModel.Eylul2023_C6,

                Ekim2023_C1 = formViewModel.Ekim2023_C1,
                Ekim2023_C2 = formViewModel.Ekim2023_C2,
                Ekim2023_C3 = formViewModel.Ekim2023_C3,
                Ekim2023_C4 = formViewModel.Ekim2023_C4,
                Ekim2023_C5 = formViewModel.Ekim2023_C5,
                Ekim2023_C6 = formViewModel.Ekim2023_C6,

                Kasim2023_C1 = formViewModel.Kasim2023_C1,
                Kasim2023_C2 = formViewModel.Kasim2023_C2,
                Kasim2023_C3 = formViewModel.Kasim2023_C3,
                Kasim2023_C4 = formViewModel.Kasim2023_C4,
                Kasim2023_C5 = formViewModel.Kasim2023_C5,
                Kasim2023_C6 = formViewModel.Kasim2023_C6,

                Aralik2023_C1 = formViewModel.Aralik2023_C1,
                Aralik2023_C2 = formViewModel.Aralik2023_C2,
                Aralik2023_C3 = formViewModel.Aralik2023_C3,
                Aralik2023_C4 = formViewModel.Aralik2023_C4,
                Aralik2023_C5 = formViewModel.Aralik2023_C5,
                Aralik2023_C6 = formViewModel.Aralik2023_C6,
            }

        };

        try
        {
            await _employeeStore.Update(employee);
            formViewModel.IsSaved = true;
            formViewModel.SaveStatus = "GÜNCELLEME BAŞARILI!";

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            formViewModel.IsSaved = false;
            formViewModel.ErrorMessage = "Personel güncelleme sırasında hata oluştu. Daha sonra tekrar deneyiniz.";
        }
        finally
        {
            formViewModel.IsSubmitting = false;
            await Task.Delay(1000);
            formViewModel.SaveStatus = string.Empty;
        }
    }
}
