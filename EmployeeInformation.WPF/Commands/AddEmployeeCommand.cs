using EmployeeInformation.Domain.Models;
using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.EF;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands;

public class AddEmployeeCommand : AsyncCommandBase
{
    readonly ModalNavigationStore _modalNavigationStore;
    readonly EmployeeStore _employeeStore;
    readonly AddEmployeeViewModel _addEmployeeViewModel;
    readonly EmployeesDbContextFactory _contextFactory;

    int sonDosyaNo;
    public AddEmployeeCommand(AddEmployeeViewModel addEmployeeViewModel, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory)
    {
        _modalNavigationStore = modalNavigationStore;
        _employeeStore = employeeStore;
        _addEmployeeViewModel = addEmployeeViewModel;
        _contextFactory = contextFactory;

        try
        {
            using (EmployeesDbContext context = _contextFactory.Create())
            {
                var sonPersonel = context.Employees.ToList().Last();
                sonDosyaNo = sonPersonel.Id;
            }
        }
        catch
        {
            sonDosyaNo = 0;
        }
    }

    public override async Task ExecuteAsync(object parameter)
    {
        EmployeeDetailsFormViewModel formViewModel = _addEmployeeViewModel.EmployeeDetailsFormViewModel;

        formViewModel.ErrorMessage = null;
        formViewModel.IsSubmitting = true;

        string dateTime = DateTime.Now.ToString("G");
        string dateTimeFile = dateTime
            .Replace(".", string.Empty)
            .Replace(":", string.Empty)
            .Replace(" ", "-");

        string secilenDosya = formViewModel.PhotoSource;

        string fileExtension = System.IO.Path.GetExtension(secilenDosya);

        string fileName = System.IO.Path.GetFileName(secilenDosya);

        string splittedName = formViewModel.Isim.Replace(" ", string.Empty);

        string newFileName = $"{splittedName}-{dateTimeFile}{fileExtension}";
        string sourceFile = secilenDosya;
        string targetPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PERSONEL_DB\\personelFoto"; //TODO KONUM DEĞİŞTİR MASTER'A AL.
        string destFile = System.IO.Path.Combine(targetPath, newFileName);


        Employee employee = new Employee
        {
            Id = sonDosyaNo + 1,
            Fotograf = destFile,
            Isim = formViewModel.Isim,
            Soyisim = formViewModel.Soyisim,
            Durum = formViewModel.Durum,
            TCKimlik = formViewModel.TCKimlik,
            DogumTarihi = formViewModel.DogumTarihi,
            MedeniDurum = formViewModel.MedeniDurum,
            EgitimDurumu = formViewModel.EgitimDurumu,
            Askerlik = formViewModel.Askerlik,

            Departman = new Department(
                formViewModel.SelectedDepartmentItem.DepartmentId,
                formViewModel.SelectedDepartmentItem.DepartmentName),

            Sector = new Sector(
                formViewModel.SelectedSectorItem.SectorId,
                formViewModel.SelectedSectorItem.SectorName),

            Education = new Education(
                formViewModel.SelectedEducationItem.EducationId,
                formViewModel.SelectedEducationItem.EducationDegree),

            Military = new MilitaryServiceStatus(
                formViewModel.SelectedMilitaryServiceItem.MilitaryServiceId,
                formViewModel.SelectedMilitaryServiceItem.MilitaryStatus),

            Maritial = new Maritial(
                formViewModel.SelectedMaritialStatusItem.MaritialStatusId,
                formViewModel.SelectedMaritialStatusItem.MaritialStatusName),

            Gorev = formViewModel.Gorev,
            IseGiris = formViewModel.IseGiris,
            IstenCikis = formViewModel.IstenCikis,
            Maas = formViewModel.Maas,
            CepTel = formViewModel.CepTel,
            CalismaSuresi = formViewModel.CalismaSuresi,
            BaslamaTarihi = formViewModel.BaslamaTarihi,
            Adres = formViewModel.EvAdresi,
            EkBilgi = formViewModel.EkBilgi,

            Vacation2018 = new Vacation2018 { Id = sonDosyaNo + 1, },
            Vacation2019 = new Vacation2019 { Id = sonDosyaNo + 1, },
            Vacation2020 = new Vacation2020 { Id = sonDosyaNo + 1, },
            Vacation2021 = new Vacation2021 { Id = sonDosyaNo + 1, },
            Vacation2022 = new Vacation2022 { Id = sonDosyaNo + 1, },
            Vacation2023 = new Vacation2023 { Id = sonDosyaNo + 1, }
        };


        try
        {
            await _employeeStore.Add(employee);

            if (secilenDosya != "/Assets/MemetAvatar.jpg")
            {
                try
                {
                    if (!Directory.Exists(targetPath))
                        Directory.CreateDirectory(targetPath);

                    File.Copy(sourceFile, destFile, true);


                }
                catch (Exception)
                {
                    MessageBox.Show("Fotoğraf yüklenirken bir hatayla karşılaşıldı", "Yükleme Hatası!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            _modalNavigationStore.Close();

        }
        catch (Exception ex)
        {
            formViewModel.ErrorMessage = "Personel kaydedilmesi sırasında hata oluştu. Daha sonra tekrar deneyiniz.";
            MessageBox.Show(ex.ToString());
        }
        finally
        {
            formViewModel.IsSubmitting = false;
        }
    }
}

