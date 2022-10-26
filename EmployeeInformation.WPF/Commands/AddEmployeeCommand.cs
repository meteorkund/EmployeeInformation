﻿using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands
{
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

            using (EmployeesDbContext context = _contextFactory.Create())
            {
                var sonPersonel = context.Employees.ToList().Last();
                sonDosyaNo = sonPersonel.Id;
            }
        }

        public override async Task ExecuteAsync(object parameter)
        {
            EmployeeDetailsFormViewModel formViewModel = _addEmployeeViewModel.EmployeeDetailsFormViewModel;

            formViewModel.ErrorMessage = null;
            formViewModel.IsSubmitting = true;

            Employee employee = new Employee(
                sonDosyaNo + 1,
                formViewModel.PhotoSource,
                formViewModel.Isim,
                formViewModel.Soyisim,
                formViewModel.Durum,
                formViewModel.TCKimlik,
                formViewModel.DogumTarihi,
                formViewModel.MedeniDurum,
                formViewModel.EgitimDurumu,
                formViewModel.Askerlik,
                formViewModel.Departman,
                formViewModel.Gorev,
                formViewModel.IseGiris,
                formViewModel.IstenCikis,
                formViewModel.Maas,
                formViewModel.CepTel,
                formViewModel.CalismaSuresi,
                formViewModel.BaslamaTarihi,
                formViewModel.EvAdresi,
                formViewModel.EkBilgi,
                DateTime.Now,
                new Vacation2018 { Id = sonDosyaNo + 1, }
                );

            string dateTime = DateTime.Now.ToString("G");
            string day = dateTime.Substring(0, 2);
            string month = dateTime.Substring(3, 2);
            string year = dateTime.Substring(6, 4);
            string hour = dateTime.Substring(11, 2);
            string minute = dateTime.Substring(14, 2);
            string second = dateTime.Substring(17, 2);

            string secilenDosya = formViewModel.PhotoSource;

            string fileExtension = System.IO.Path.GetExtension(secilenDosya);

            string fileName = System.IO.Path.GetFileName(secilenDosya);

            string[] splittedName = formViewModel.Isim.Split(' ');

            string newFileName = $"{splittedName[0]}-{formViewModel.Soyisim}-{day}{month}{year}-{hour}{minute}{second}{fileExtension}";
            string sourceFile = secilenDosya;
            string targetPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PERSONEL_DB\\personelFoto"; //TODO KONUM DEĞİŞTİR MASTER'A AL.
            string destFile = System.IO.Path.Combine(targetPath, newFileName);

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
            catch (Exception)
            {
                formViewModel.ErrorMessage = "Personel kaydedilmesi sırasında hata oluştu. Daha sonra tekrar deneyiniz.";
            }
            finally
            {
                formViewModel.IsSubmitting = false;
            }
        }
    }
}

